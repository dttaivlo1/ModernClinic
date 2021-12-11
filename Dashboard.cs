using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModernClinic
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'modernCareDataSet3.BENHNHAN' table. You can move, or remove it, as needed.
            this.bENHNHANTableAdapter1.Fill(this.modernCareDataSet3.BENHNHAN);
            // TODO: This line of code loads data into the 'modernCareDataSet.BENHNHAN' table. You can move, or remove it, as needed.
            this.bENHNHANTableAdapter.Fill(this.modernCareDataSet.BENHNHAN);
            // TODO: This line of code loads data into the 'modernCareDataSet.BENHNHAN' table. You can move, or remove it, as needed.
            this.bENHNHANTableAdapter.Fill(this.modernCareDataSet.BENHNHAN);

        }

        private void getAllBenhNhanToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.bENHNHANTableAdapter.GetAllBenhNhan(this.modernCareDataSet.BENHNHAN);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        
    }
}
