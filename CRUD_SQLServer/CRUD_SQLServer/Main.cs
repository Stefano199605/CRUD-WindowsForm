using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_SQLServer
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        #region EVENTS
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            OpenContactDetailsDialog();
        }
        #endregion


        #region PRIVATE METHODS
          
        private void OpenContactDetailsDialog()
        {
            DetalleContactos contactosdetalles = new DetalleContactos();
            contactosdetalles.ShowDialog();
        }
        #endregion
    }
}
