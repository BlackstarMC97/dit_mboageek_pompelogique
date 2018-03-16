using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using Prolog;

namespace PompeEssence_Logique
{
    public partial class Form1 : KryptonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int etat_pompe = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public int traductionBooleenne(bool booleen)
        {
            if (booleen)
                return 1;
            else
                return 0;
        }

        public void determinerEtatPompe()
        {
            int etat_marche = traductionBooleenne(kryptonCheckButton1.Checked);
            int etat_arret = traductionBooleenne(kryptonCheckButton2.Checked);

            var prolog = new PrologEngine(persistentCommandHistory: false);
            prolog.Consult("pompe_essence.pl");

            SolutionSet resultat = new SolutionSet();

            resultat = prolog.GetAllSolutions("pompe_essence.pl", "etat_pompe(" + etat_arret + "," + etat_marche + "," + etat_pompe + ", R)", 1);

            //MessageBox.Show(resultat.ToString());

            foreach (Solution x in resultat.NextSolution)
            {
                foreach (Variable you in x.NextVariable)
                {
                    //MessageBox.Show(you.Value);
                    etat_pompe = int.Parse(you.Value);
                }
            }

            if (etat_pompe == 1)
            {
                toolStripStatusLabel1.ForeColor = Color.DarkGreen;
                toolStripStatusLabel1.Text = "La pompe fonctionne";
            }
            else
            {
                toolStripStatusLabel1.ForeColor = Color.Red;
                toolStripStatusLabel1.Text = "La pompe est arrêtée";
            }
        }

        private void kryptonCheckButton1_Click(object sender, EventArgs e)
        {
            determinerEtatPompe();
        }

        private void kryptonCheckButton2_Click(object sender, EventArgs e)
        {
            determinerEtatPompe();
        }
    }
}
