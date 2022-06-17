using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using Lab5.Objects;

namespace _4сем_c_sharp_5
{
    public partial class Form1 : Form
    {
        List<ViewObject> viewObjects;
        object viewObjectsLocker;

        List<ViewFigure> viewFigures;
        object viewFiguresLocker;

        Painter painter;

        ViewObject building1, building2;

        List<Person> people;
        object peopleLocker;

        List<Crossroads> crossroads;

        int maxCrossroadsNumber;

        IEnumerable<Type> rescueServiceTypes;
        List<string> notifications;


        public Form1()
        {
            InitializeComponent();

            viewObjects = new List<ViewObject>();
            viewObjectsLocker = new object();

            viewFigures = new List<ViewFigure>();
            viewFiguresLocker = new object();

            people = new List<Person>();
            peopleLocker = new object();

            rescueServiceTypes = Assembly.Load("Lab5.Objects").GetTypes().Where(type => !type.IsAbstract && type.GetInterface("IRescueSecvice") != null);

            notifications = new List<string>();
            maxCrossroadsNumber = (int)(pictureBox1.Height / Properties.Resources.crossRoads.Height);

            crossroads = new List<Crossroads>();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            painter.Stop();

            foreach (var item in crossroads)
            {
                item.IsCanceled = true;
            }

            foreach (var item in viewFigures)
            {
                if (item is ViewFigure viewFigure)
                {
                    viewFigure.figure.IsCanceled = true;
                }
            }
        }

        private void addPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Person person = new Person(Notification, building1.X, building1.Y);
            lock(peopleLocker)
            {
                people.Add(person);
            }
            lock(viewFigures)
            {
                viewFigures.Add(new ViewFigure(person, Properties.Resources.person));
            }

            Task.Run(person.Start);
        }

        private void addRescueServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Type rescueServiceType = typeof(Firefighters);
            rescueServiceForm rescueServiceForm = new rescueServiceForm(rescueServiceTypes);

            if (rescueServiceForm.DialogResult == DialogResult.OK)
            {
                rescueServiceType = rescueServiceForm.SelectedType;
            }

            RescueService rescueService = Activator.CreateInstance(rescueServiceType, new object[] { (Action<string>)Notification, building1.X, building1.Y, people, peopleLocker }) as RescueService;

            lock(peopleLocker)
            {
                viewFigures.Add(new ViewFigure(rescueService, Properties.Resources.rescueService));
            }

            Task.Run(rescueService.Start);
        }

        void setBuildingsSize()
        {
            building1.X = pictureBox1.Width - Properties.Resources.building.Width / 2;
            building1.Y = pictureBox1.Height - Properties.Resources.building.Height / 2;

            building2.X = pictureBox1.Width - Properties.Resources.building2.Width / 2;
            building2.Y = pictureBox1.Height - Properties.Resources.building2.Width/2;
        }

        void Notification(string message)
        {
            textBox1.Invoke((MethodInvoker)delegate
            {
                notifications.Add(message);

                if (notifications.Count > 15)
                {
                    notifications = notifications.GetRange(5, 9);

                    textBox1.Text = "";

                    foreach (var item in notifications)
                    {
                        textBox1.Text += item + "\r\n\r\n";
                    }
                }

                textBox1.Text += message + "\r\n\r\n";
            });
        }

        void addCrossroads(string crossroadsName = "zxc", int maxPeopleNumber = 5)
        {
            float x = Properties.Resources.crossRoads.Width / 2;
            float y = Properties.Resources.crossRoads.Height / 2;

            y += people.Count() * Properties.Resources.crossRoads.Height / 2;
            crossroads.Add(new Crossroads(Notification, people, peopleLocker, x, y, crossroadsName, maxPeopleNumber));

            lock (viewObjectsLocker)
            {
                viewObjects.Add(new ViewObject(Properties.Resources.crossRoads, x, y));
            }

            Task.Run(crossroads[crossroads.Count() - 1].Start);

            if (crossroads.Count >= maxCrossroadsNumber)
                addCrossroadsToolStripMenuItem.Enabled = false;
        }

        void generatePeople(int peopleNumber)
        {
            for (int i = 0; i<peopleNumber; i++)
            {
                var newPerson = new Person(Notification, building1.X, building1.Y);

                people.Add(newPerson);

                viewFigures.Add(new ViewFigure(newPerson, Properties.Resources.person));
                Task.Run(newPerson.Start);
            }   
        }

       

        void generateRescueServices(int rescueServicesNumber)
        {
            object[] rescueServiceArgs = new object[] { (Action<string>)Notification, building2.X, building2.Y, people, peopleLocker };

            for (int i = 0; i < rescueServicesNumber; i++)
            {
                foreach (var item in rescueServiceTypes)
                {
                    RescueService newRescueService = Activator.CreateInstance(item, rescueServiceArgs) as RescueService;
                    viewFigures.Add(new ViewFigure(newRescueService, Properties.Resources.rescueService));
                    Task.Run(newRescueService.Start);
                }
            }
        }

        private void addCrossroadsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addCrossroads();
        }

        private void actionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addPersonToolStripMenuItem.Enabled = true;
            addRescueServiceToolStripMenuItem.Enabled = true;
            addCrossroadsToolStripMenuItem.Enabled = true;
            actionToolStripMenuItem.Enabled = false;

            painter = new Painter(pictureBox1, Color.FromArgb(128, 255, 128), new Font(textBox1.Font.FontFamily, 10f, textBox1.Font.Style), viewObjects, viewObjectsLocker, viewFigures, viewFiguresLocker);

            building1 = new ViewObject(Properties.Resources.building);
            building2 = new ViewObject(Properties.Resources.building2);
            setBuildingsSize();
            viewObjects.Add(building1);
            viewObjects.Add(building2);

            addCrossroads();
            generatePeople(5);
            generateRescueServices(3);
            painter.Start();


        }
    }
}
