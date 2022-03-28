using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_SQLServer
{
    public class BusinessLogicLayer
    {
        private DataAccessLayer dataAccessLayer;
        public BusinessLogicLayer()
        {
            dataAccessLayer = new DataAccessLayer();
        }
        public Contacts SaveContact(Contacts contact)
        {
            if (contact.Id == 0)
            {
                //dataAccessLayer.InsertContact();
            }
            else
            {
                //dataAccessLayer.UpdateContact();
            }
        }
    }
}
