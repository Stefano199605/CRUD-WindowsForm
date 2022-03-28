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
        private SqlConnection conn = new SqlConnection("Server=DESKTOP-3LUEQ59;DataBase=WinFormsContacts;UID=sa;password=p0deroso12");

        public void InsertContact(contacts contact)
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
                command.Parameters.Add(firstName);
                command.Parameters.Add(LastName);
                command.Parameters.Add(Phone);
                command.Parameters.Add(Address);
                command.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        public List<contacts> GetContacts()
        {
            try
            {
                conn.Open();
                string query = @"SELECT id,FirstName,LastName,Phone Address FROM Contacts";
                SqlCommand command = new SqlCommand(query, conn);

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
