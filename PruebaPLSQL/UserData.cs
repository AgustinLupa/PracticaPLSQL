using Oracle.ManagedDataAccess.Client;
using PruebaPLSQL.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaPLSQL.Data
{
    public class UserData
    {
        public async IEnumerable<Users> GetAllUsers()
        {
            List<Users> userList = new List<Users>();

            using (OracleConnection con = new OracleConnection())
            {
                con.ConnectionString = Context.conectionString;
                con.Open();

                using (OracleCommand cmd = new OracleCommand("SELECT * FROM users", con))
                {
                    using (OracleDataReader reader = (OracleDataReader)await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {                            
                            Users user = new Users
                            {
                                Id = Convert.ToInt32(reader["id_user"]),
                                Username = reader["username"].ToString(),
                                Password = reader["password"].ToString(),                                
                            };

                            userList.Add(user);
                        }
                        return userList;
                    }
                }
            }
            
        }
        
    }
}
