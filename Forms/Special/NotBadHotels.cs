using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class NotBadHotels : Form
    {
        public NotBadHotels()
        {
            InitializeComponent();
        }

        private void NotBadHotels_Load(object sender, EventArgs e)
        {
            this.notBadHotelsTableAdapter.Fill(this.travelAgencyDataSet.NotBadHotels);
        }
    }
}
