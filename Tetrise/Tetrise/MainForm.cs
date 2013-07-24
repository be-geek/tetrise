using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Tetrise
{
    struct Block
    {
        public Color color;
        public bool exist;
    }

    public partial class MainForm : Form
    {
        private Graphics playGraph;
        private Graphics viewGraph;
        private FieldPlay play;
        private FieldView view;
        private Shape curShape;
        private Shape nextShape;

        private int Level;
        private long Score;
        private double Gear;

        public MainForm()
        {
            InitializeComponent();
            playGraph = PlayField.CreateGraphics();//avoid refresh too often
            viewGraph = PreView.CreateGraphics();
            play = new FieldPlay();
            view = new FieldView();

        }

        private void StartButton_Click(object sender, EventArgs e)
        {

            if (ExitButton.Enabled)
            {//game started
                StartButton.Text = "Stop";
                ExitButton.Enabled = false;
  
                play.clearField();
                Prepare();
                Level = 0;
                Score = 0;
                Gear = 0.5;
                SpeedTimer.Enabled = true;
            }
            else
            {//game stop
                StartButton.Text = "Start";
                ExitButton.Enabled = true;
                SpeedTimer.Enabled = false;
            }
            
        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)//deal key events
        {

            switch (e.KeyCode.ToString())
            {
                case "Right": curShape.moveRight(play); break;
                case "Left":  curShape.moveLeft(play); break;
                case "Down": curShape.moveDown(play); curShape.moveDown(play); break;
                case "Up":    curShape.shift(play); break;
                default: break;

            }

            if (curShape != null)
            {
                play.placeShape(curShape);
                play.showBlocks(playGraph);
            }
        }

        private void Prepare()
        {
            //prepare next shape
            Random t = new Random();
            

            //if current shape is null, make the current shape and next shape
            if (curShape == null)
            {
                curShape = ShapeFacotry.createShape(t.Next() % 7);
                nextShape = ShapeFacotry.createShape(t.Next() % 7);
            }
            else
            {
                curShape = nextShape;
                nextShape = ShapeFacotry.createShape(t.Next() % 7);
            }

            //show next shape in preview box
            view.clearField();
            nextShape.pos_x = (6 - nextShape.width) / 2;
            nextShape.pos_y = (6 - nextShape.height) / 2;
            if (nextShape != null)
            { 
                view.placeShape(nextShape);
                view.showBlocks(viewGraph);
            }



            //set the start position in the playfield
            curShape.pos_x = 5;
            curShape.pos_y = 0;

            if (curShape != null)
            {
                play.placeShape(curShape);
                play.showBlocks(playGraph);
            }      
        }

        private void SpeedTimer_Tick(object sender, EventArgs e)
        {
            SpeedTimer.Interval = (int)(1000.0 * Gear);
            Level = (int)(Score / 1000);
            if (Level <= 5)
                Gear = 0.1 * (6 - Level);
            else Level = 5;

            Label_level.Text = "Level:" + Level.ToString();
            Label_score.Text = "Score:" + Score.ToString();

            int basePoint = 0, bouncePoint = 0;

            if (!curShape.moveDown(play))
            {
                basePoint = play.check()*100;
                bouncePoint = (basePoint / 100 * 10) * (basePoint / 100);
                Score += basePoint;
                Score += bouncePoint;
                
                Prepare();

                if ((curShape.pos_y == 0)&&(!curShape.moveDown(play)))
                {

                    StartButton.Text = "Start";
                    ExitButton.Enabled = true;
                    SpeedTimer.Enabled = false;
                    MessageBox.Show("Game Over");
                }
            }

            if (curShape != null)
            {
                play.placeShape(curShape);
                play.showBlocks(playGraph);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}