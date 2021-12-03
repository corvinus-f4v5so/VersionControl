using Microsimulation.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Microsimulation
{
    public partial class Form1 : Form
    {
        List<Person> Population = new List<Person>();
        List<BirthProbability> BirthProbabilities = new List<BirthProbability>();
        List<DeathProbability> DeathProbabilities = new List<DeathProbability>();
        List<int> NumberOfMen = new List<int>();
        List<int> NumberOfWomen = new List<int>();

        Random rnd = new Random(1234);

        public Form1()
        {
            InitializeComponent();
        }

        private void Simulation(int endYear)
        {
            

            for (int year = 2005; year <= endYear ; year++)
            {
                for (int i = 0; i < Population.Count; i++)
                {
                    SimStep(year, Population[i]);
                }

                int nbrOfMales = (from x in Population
                                  where x.Gender == Gender.Male && x.IsAlive
                                  select x).Count();

                int nbrOfFemales = (from x in Population
                                    where x.Gender == Gender.Female && x.IsAlive
                                    select x).Count();

                Console.WriteLine(
                    string.Format("Év:{0} Fiúk:{1} Lányok:{2}", year, nbrOfMales, nbrOfFemales));
                NumberOfMen.Add(nbrOfMales);
                NumberOfWomen.Add(nbrOfFemales);
            }

            DisplayResults(endYear);
        }

        private void DisplayResults(int endYear)
        {
            for (int year = 2005; year <= endYear; year++)
            {
                richTextBox1.Text += "Szimulációs év: " + year + "\n \t Fiúk: " + NumberOfMen[year-2005] + "\n \t Lányok: " + NumberOfWomen[year-2005] +"\n";
            }
        }

        public void SimStep(int year, Person person)
        {
            if (!person.IsAlive) return;

            byte age = (byte)(year - person.BirthYear);

            double pDeath = (from x in DeathProbabilities
                             where x.Gender == person.Gender && x.Age == age
                             select x.P).FirstOrDefault();

            if (rnd.NextDouble() <= pDeath) person.IsAlive = false ;

            if(person.IsAlive && person.Gender == Gender.Female)
            {
                double pBirth = (from x in BirthProbabilities
                          where x.Age == age
                          select x.P).FirstOrDefault();

                if (rnd.NextDouble() <= pBirth)
                {
                    Person p = new Person();
                    p.BirthYear = year;
                    p.Gender = (Gender)(rnd.Next(1, 3));
                    p.NbrOfChildren = 0;
                    Population.Add(p);
                }
            }
        }

        public List<Person> GetPopulation(string csvpath)
        {
            List<Person> population = new List<Person>();

            using (StreamReader sr = new StreamReader(csvpath, Encoding.Default))
            {
                while(!sr.EndOfStream)
                {
                    var line = sr.ReadLine().Split(';');
                    population.Add(new Person()
                    {
                        BirthYear = int.Parse(line[0]),
                        Gender = (Gender)Enum.Parse(typeof(Gender), line[1]),
                        NbrOfChildren = int.Parse(line[2])
                    });

                }
            }
            return population;
        }

        public List<BirthProbability> GetBirthPorbability(string csvpath)
        {
            List<BirthProbability> birthProbabilities = new List<BirthProbability>();

            using (StreamReader sr = new StreamReader(csvpath, Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine().Split(';');
                    birthProbabilities.Add(new BirthProbability()
                    {
                        Age = int.Parse(line[0]),
                        NbrOfChildren = int.Parse(line[1]),
                        P = double.Parse(line[2])
                    });

                }
            }
            return birthProbabilities;
        }

        public List<DeathProbability> GetBDeathPorbability(string csvpath)
        {
            List<DeathProbability> deathProbabilities = new List<DeathProbability>();

            using (StreamReader sr = new StreamReader(csvpath, Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine().Split(';');
                    deathProbabilities.Add(new DeathProbability()
                    {
                        Gender = (Gender)Enum.Parse(typeof(Gender), line[0]),
                        Age = int.Parse(line[1]),
                        P = double.Parse(line[2])
                    });

                }
            }
            return deathProbabilities;
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            NumberOfMen.Clear();
            NumberOfWomen.Clear();
            Population.Clear();
            BirthProbabilities.Clear();
            DeathProbabilities.Clear();
            Population = GetPopulation(FileTextBox.Text);
            BirthProbabilities = GetBirthPorbability(@"C:\Temp\születés.csv");
            DeathProbabilities = GetBDeathPorbability(@"C:\Temp\halál.csv");
            Simulation(int.Parse(endYearNumericUpDown.Value.ToString()));
        }

        private void BrowseBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.InitialDirectory = @"C:\Temp";
            if (of.ShowDialog() != DialogResult.OK) return;
            FileTextBox.Text = of.FileName;
        }
    }
}
