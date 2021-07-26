using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace ShopApp
{
    public partial class frmThemNV : Form
    {
        public frmThemNV()
        {
            InitializeComponent();
        }

        private void frmThemNV_Load(object sender, EventArgs e)
        {
            dtdvNhanVien.DataSource = BUS_staff.getDSNV();
        }
    }
}
