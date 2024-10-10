using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeStock.PL
{
    public partial class FRM_Menu : Form
    {
        public FRM_Menu()
        {
            InitializeComponent();
            panel1.Size = new Size(229, 612);
            pnlParametre.Visible = false;
        }

        private void FRM_Menu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            pnlBut.Top = btnproduit.Top;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (panel1.Width == 229)
                panel1.Size = new Size(73, 612);
            else
                panel1.Size = new Size(229, 612);
        }

        private void btnclient_Click(object sender, EventArgs e)
        {
            pnlBut.Top = btnclient.Top;
        }

        private void btncategorie_Click(object sender, EventArgs e)
        {
            pnlBut.Top = btncategorie.Top;
        }

        private void btncommande_Click(object sender, EventArgs e)
        {
            pnlBut.Top = btncommande.Top;
        }

        private void btnutilisateur_Click(object sender, EventArgs e)
        {
            pnlBut.Top = btnutilisateur.Top;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            //pnlParametre.Size = new Size(361,206);
            pnlParametre.Visible = !pnlParametre.Visible;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Afficher formulaire de connexion
            FRM_Connexion frmC = new FRM_Connexion();
            frmC.ShowDialog();
        }
    }
}
