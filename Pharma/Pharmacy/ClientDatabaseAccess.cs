﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy
{
    class ClientDatabaseAccess
    {
        SqlConnection conn;
        String connectionString = @"Data Source=PEN\Stephen;Initial Catalog=Inventory;Trusted_Connection=True;Integrated Security = true";
        public ClientDatabaseAccess()
        {
            conn = new SqlConnection(connectionString);
            conn.ConnectionString = this.connectionString;
            conn.Open();
        }
        public SqlConnection getConnection()
        {
            return this.conn;
        }
        public void Close()
        {
            conn.Close();
        }

        public List<Client> getAllClients()
        {
            SqlCommand command;
            command = new SqlCommand("Select * from CLient", this.conn);
            List<Client> customers = new List<Client>();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Client temp = new Client((int)reader["ClientID"], reader["FirstName"].ToString(), reader["LastName"].ToString(), reader["Company"].ToString(), reader["Contact"].ToString(), reader["CustomerAddress"].ToString(), reader["EmailAddress"].ToString());
                    customers.Add(temp);
                }
            }
            return customers;
        }

        public bool addClient(Client customer)
        {
            SqlCommand command;
            command = new SqlCommand("Insert into CLient values(@firstname,@lastname,@company,@contact,@address,@email)", this.getConnection());
            SqlParameter lastnameParam = new SqlParameter("@lastname", SqlDbType.VarChar, 255);
            SqlParameter contactParam = new SqlParameter("@contact", SqlDbType.VarChar, 255);
            SqlParameter firstnameParam = new SqlParameter("@firstname", SqlDbType.VarChar, 255);
            SqlParameter companyParam = new SqlParameter("@company", SqlDbType.VarChar, 255);
            SqlParameter addressParam = new SqlParameter("@address", SqlDbType.VarChar, 255);
            SqlParameter emailParam = new SqlParameter("@email", SqlDbType.VarChar, 255);
            contactParam.Value = customer.Contact;
            lastnameParam.Value = customer.LastName;
            firstnameParam.Value = customer.FirstName;
            emailParam.Value = customer.EmailAddress;
            companyParam.Value = customer.Company;
            addressParam.Value = customer.CustomerAddress;
            command.Parameters.Add(emailParam);
            command.Parameters.Add(addressParam);
            command.Parameters.Add(companyParam);
            command.Parameters.Add(lastnameParam);
            command.Parameters.Add(firstnameParam);
            command.Parameters.Add(contactParam);
            command.Prepare();
            return command.ExecuteNonQuery() == 1;
        }
        public bool addClient(string firstname, string lastname, string company, string contact, string address, string email)
        {
            SqlCommand command;
            command = new SqlCommand("Insert into CLient values(@firstname,@lastname,@company,@contact,@address,@email)", this.getConnection());
            SqlParameter lastnameParam = new SqlParameter("@lastname", SqlDbType.VarChar, 255);
            SqlParameter contactParam = new SqlParameter("@contact", SqlDbType.VarChar, 255);
            SqlParameter firstnameParam = new SqlParameter("@firstname", SqlDbType.VarChar, 255);
            SqlParameter companyParam = new SqlParameter("@company", SqlDbType.VarChar, 255);
            SqlParameter addressParam = new SqlParameter("@address", SqlDbType.VarChar, 255);
            SqlParameter emailParam = new SqlParameter("@email", SqlDbType.VarChar, 255);
            contactParam.Value = contact;
            lastnameParam.Value = lastname;
            firstnameParam.Value = firstname;
            emailParam.Value = email;
            companyParam.Value = company;
            addressParam.Value = address;
            command.Parameters.Add(emailParam);
            command.Parameters.Add(addressParam);
            command.Parameters.Add(companyParam);
            command.Parameters.Add(lastnameParam);
            command.Parameters.Add(firstnameParam);
            command.Parameters.Add(contactParam);
            command.Prepare();
            return command.ExecuteNonQuery() == 1;
        }
        public bool updateItemByFirstName(int id, string value)
        {
            SqlCommand command;
            command = new SqlCommand("Update CLient set FirstName=@value where ClientID = @ID", this.conn);
            SqlParameter valueParam = new SqlParameter("@value", SqlDbType.VarChar, 255);
            SqlParameter idParam = new SqlParameter("@ID", SqlDbType.Int);
            valueParam.Value = value;
            idParam.Value = id;
            command.Parameters.Add(valueParam);
            command.Parameters.Add(idParam);
            command.Prepare();
            return command.ExecuteNonQuery() == 1;
        }

        public bool updateItemByLastName(int id, string value)
        {
            SqlCommand command;
            command = new SqlCommand("Update CLient set LastName=@value where ClientID = @ID", this.conn);
            SqlParameter valueParam = new SqlParameter("@value", SqlDbType.VarChar, 255);
            SqlParameter idParam = new SqlParameter("@ID", SqlDbType.Int);
            valueParam.Value = value;
            idParam.Value = id;
            command.Parameters.Add(valueParam);
            command.Parameters.Add(idParam);
            command.Prepare();
            return command.ExecuteNonQuery() == 1;
        }
        public bool updateItemByCompany(int id, string value)
        {
            SqlCommand command;
            command = new SqlCommand("Update CLient set Company=@value where ClientID = @ID", this.conn);
            SqlParameter valueParam = new SqlParameter("@value", SqlDbType.VarChar, 255);
            SqlParameter idParam = new SqlParameter("@ID", SqlDbType.Int);
            valueParam.Value = value;
            idParam.Value = id;
            command.Parameters.Add(valueParam);
            command.Parameters.Add(idParam);
            command.Prepare();
            return command.ExecuteNonQuery() == 1;
        }

        public bool updateItemByContact(int id, string value)
        {
            SqlCommand command;
            command = new SqlCommand("Update CLient set Contact=@value where ClientID = @ID", this.conn);
            SqlParameter valueParam = new SqlParameter("@value", SqlDbType.VarChar, 255);
            SqlParameter idParam = new SqlParameter("@ID", SqlDbType.Int);
            valueParam.Value = value;
            idParam.Value = id;
            command.Parameters.Add(valueParam);
            command.Parameters.Add(idParam);
            command.Prepare();
            return command.ExecuteNonQuery() == 1;
        }

        public bool updateItemByAddress(int id, string value)
        {
            SqlCommand command;
            command = new SqlCommand("Update CLient set CustomerAddress=@value where ClientID = @ID", this.conn);
            SqlParameter valueParam = new SqlParameter("@value", SqlDbType.VarChar, 255);
            SqlParameter idParam = new SqlParameter("@ID", SqlDbType.Int);
            valueParam.Value = value;
            idParam.Value = id;
            command.Parameters.Add(valueParam);
            command.Parameters.Add(idParam);
            command.Prepare();
            return command.ExecuteNonQuery() == 1;
        }

        public bool updateItemByEmail(int id, string value)
        {
            SqlCommand command;
            command = new SqlCommand("Update CLient set EmailAddress=@value where ClientID = @ID", this.conn);
            SqlParameter valueParam = new SqlParameter("@value", SqlDbType.VarChar, 255);
            SqlParameter idParam = new SqlParameter("@ID", SqlDbType.Int);
            valueParam.Value = value;
            idParam.Value = id;
            command.Parameters.Add(valueParam);
            command.Parameters.Add(idParam);
            command.Prepare();
            return command.ExecuteNonQuery() == 1;
        }

        public bool deleteClient(int id)
        {
            SqlCommand command;
            command = new SqlCommand("Delete from CLient where ClientID = @ID", this.conn);
            SqlParameter idParam = new SqlParameter("@ID", SqlDbType.Int);
            idParam.Value = id;
            command.Parameters.Add(idParam);
            command.Prepare();
            return command.ExecuteNonQuery() == 1;
        }
    }
}
