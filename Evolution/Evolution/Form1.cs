﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorldsHardestGame;

namespace Evolution
{
    public partial class Form1 : Form
    {
        GameController gc = new GameController();
        GameArea ga;

        int populationSize = 100;
        int nbrOfStesp = 10;
        int nbrOfStespIncrement = 10;
        int generation = 1;




        public Form1()
        {
            InitializeComponent();

            ga = gc.ActivateDisplay();
            this.Controls.Add(ga);

            gc.GameOver += Gc_GameOver;

            for (int i = 0; i < populationSize; i++)
            {
                gc.AddPlayer(nbrOfStesp);
            }
            
            gc.Start();
        }

        private void Gc_GameOver(object sender)
        {
            generation++;
            labelGen.Text = string.Format( "{0}. generáció", generation);

            var playerList = from p in gc.GetCurrentPlayers()
                             orderby p.GetFitness() descending
                             select p;

            var topPerformers = playerList.Take(populationSize / 2).ToList();
        }
    }
}
