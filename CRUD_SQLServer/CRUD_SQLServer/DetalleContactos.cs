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
    public partial class DetalleContactos : Form
    {
        private BusinessLogicLayer businessLogicLayer;
        public DetalleContactos()
        {
            InitializeComponent();
            businessLogicLayer = new BusinessLogicLayer();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            SaveContact();
        }

        private void SaveContact()
        {
            contacts contact = new contacts();
            contact.FirstName = txtFirstName.Text;
            contact.LastName = txtLastName.Text;
            contact.Phone = txtPhone.Text;
            contact.Address = txtAddress.Text;

            businessLogicLayer.SaveContact(contact);
        }
    }
}
