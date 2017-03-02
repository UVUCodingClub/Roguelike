using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            txtEnemyName.Text = "Bob";
            txtEnemyHealth.Text = e1.getEnemyHealth().ToString();
        }

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

    }
}
