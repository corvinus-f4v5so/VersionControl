using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using week08.Abstractions;
using week08.Entities;

namespace week08
{
    public partial class Form1 : Form
    {
        Toy _nextToy;

        List<Toy> _toys= new List<Toy>();

        private IToyFactory _factory;
        public IToyFactory Factory {
            get { return _factory; }
            set 
            { 
                _factory = value;
                DisplayNext();
            } 
        }

        public Form1()
        {
            InitializeComponent();
            Factory = new CarFactory();
        }

        private void createTimer_Tick(object sender, EventArgs e)
        {
            var toy = Factory.CreateNew();
            _toys.Add(toy);
            toy.Left = -toy.Width;
            mainPanel.Controls.Add(toy);
        }

        private void conveyorTimer_Tick(object sender, EventArgs e)
        {
            var mostRightToy = 0;
            foreach (var toy in _toys)
            {
                toy.MoveToy();
                if (toy.Left > mostRightToy) mostRightToy = toy.Left;
            }

            if(mostRightToy > 1000)
            {
                var oldestToy = _toys[0];
                _toys.Remove(oldestToy);
                mainPanel.Controls.Remove(oldestToy);
            }
        }

        private void ballButton_Click(object sender, EventArgs e)
        {
            Factory = new BallFactory 
            {
                BallColor = ballColorButton.BackColor
            };
        }

        private void carButton_Click(object sender, EventArgs e)
        {
            Factory = new CarFactory();
        }

        private void presentButton_Click(object sender, EventArgs e)
        {
            Factory = new PresentFactory
            {
                RibbonColor = ribbonButton.BackColor,
                BoxColor = boxButton.BackColor
            };
        }

        void DisplayNext()
        {
            if( _nextToy != null)
            {
                Controls.Remove(_nextToy);
            }
                _nextToy = Factory.CreateNew();
                _nextToy.Top = nextLabel.Top;
                _nextToy.Left = nextLabel.Left + nextLabel.Width + 20;
                Controls.Add(_nextToy);
            
        }

        private void ballColorButton_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var colorPicker = new ColorDialog();

            colorPicker.Color = ballColorButton.BackColor;
            if (colorPicker.ShowDialog() != DialogResult.OK) return;
            button.BackColor = colorPicker.Color;
        }

        private void ribbonButton_Click(object sender, EventArgs e)
        {

        }

        private void boxButton_Click(object sender, EventArgs e)
        {

        }
    }
}
