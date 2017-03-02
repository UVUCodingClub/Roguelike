using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Roguelike
{
    public partial class FrmMain : Form
    {
        //have to put objects out here to make them global to all event handlers
        Player char1 = new Player("Benny");
        Enemy e1 = new Enemy();
        public FrmMain()
        {
            InitializeComponent();

            //instantiate two new objects of player and enemy

            //initialize the text boxes with info
            txtPlayerName.Text = char1.getName();
            txtPlayerHealth.Text = char1.getHP().ToString();

            txtEnemyName.Text = "Sewer Rat";
            txtEnemyHealth.Text = e1.getEnemyHealth().ToString();
        }

        /// <summary>
        /// plays out the attack sequence (player first then enemies)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAttack_Click(object sender, EventArgs e)
        {
            //Players attack
            //converts the string back to an int to do the maths
            int enemyHealth;
            int.TryParse(txtEnemyHealth.Text, out enemyHealth);

            enemyHealth -= char1.attack(); // the character attacks


            if (enemyHealth <= 0) //check if the monster died
            {
                MessageBox.Show("You defeated the monster!"); //show a message box
                txtEnemyHealth.Text = "0";
            }
            else //monster didnt die :(
            {
                txtEnemyHealth.Text = enemyHealth.ToString(); //update the string 
            }


            //Enemy's attack, same as above but in reverse
            int playerHealth;
            int.TryParse(txtPlayerHealth.Text, out playerHealth);

            playerHealth -= e1.Attack();

            if(playerHealth <= 0)
            {
                MessageBox.Show("You died...");
                txtPlayerHealth.Text = "0";
            }
            else
            {
                txtPlayerHealth.Text = playerHealth.ToString();
            }

        }//end of Attack btn event handler

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutTheMakersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string credits = "Credits(In alphabetical order)\n";
            string names = "Jesse Croxford\nMax Nelson\nNathan Schulzke\nBenny Yamagata\n";
            string copyright = "Copyright 2017";
            MessageBox.Show(credits + names + copyright);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO: FIX SO IT ACTUALLY SAVES THE FILE
            //currently saves in app folder


            //generates a path to the my documents folder and creates a streamwriter object to write a txt file there
            //string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            //StreamWriter saveFile = new StreamWriter(path + "save_game.txt");
            StreamWriter saveFile = new StreamWriter("save_game.txt");

            //Will save current rendition of the character
            saveFile.WriteLine($"Name: {char1.getName()}");
            saveFile.WriteLine($"XP: {char1.getXP()}");
            saveFile.WriteLine($"HP: {char1.getHP()}");
            saveFile.WriteLine($"Strength: {char1.getStrength()}");
            saveFile.Close();
        }
    }
}
