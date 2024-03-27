using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodXYZ.Halaman.Kasir.Page
{
    public partial class KelolaTransaksi : Form
    {
        public KelolaTransaksi()
        {
            InitializeComponent();
        }

        private void Print_Transaksi(object sender, EventArgs e)
        {
            printTransaksi.ShowDialog();
        }
    }
}
