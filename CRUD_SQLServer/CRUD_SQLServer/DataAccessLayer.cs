using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_SQLServer
{
    public class DataAccessLayer
    {
        private SqlConnection conn = new SqlConnection("Server=DESKTOP-3LUEQ59;DataBase=WinFormsContact;UID=sa;password=p0deroso12");

        public void InsertContact(Contacts contact)
        {
            try
            {
                conn.Open();
                string query = @"Insert Into Contacts(FirstName,LastName,Phone,Address) VALUES(@FirstName,@LastName,@Phone,@Address)";
                SqlParameter firstName = new SqlParameter();
                firstName.ParameterName = "@FirstName";
                firstName.Value = contact.FirstName;
                firstName.DbType =System.Data.DbType.String;

                SqlParameter LastName = new SqlParameter("@LastName",contact.LastName);
                SqlParameter Phone = new SqlParameter("@Phone", contact.Phone);
                SqlParameter Address = new SqlParameter("@Address", contact.Address);

                SqlCommand command = new SqlCommand(query, conn);
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
