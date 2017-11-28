using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CoolScreenService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        private const string ConnectionString = "Server=tcp:coolscreen.database.windows.net,1433;Initial Catalog=CoolScreen;Persist Security Info=False;User ID=cookied;Password=Daniel1993;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        public void CreateOpskrift(OpskriftClass opskriftClass)
        {
            const string insertOpskrift = "insert into Opskrifter (Titel, Ingredienser, Opskrift) values (@Titel, @Ingrediser, @Opskrift)";
            using (SqlConnection dataConnection = new SqlConnection(ConnectionString))
            {
                dataConnection.Open();
                using (SqlCommand insertCommand = new SqlCommand(insertOpskrift, dataConnection))
                {
                    insertCommand.Parameters.AddWithValue("@Titel", opskriftClass.Titel);
                    insertCommand.Parameters.AddWithValue("@Ingredienser", opskriftClass.Ingredienser);
                    insertCommand.Parameters.AddWithValue("@Opskrift", opskriftClass.Opskrift);
                    insertCommand.ExecuteNonQuery();
                }
            }
        }

        public OpskriftClass ReadOpskrift(int id)
        {
            const string SelectOpskrift = "select * from Opskrifter where Id = @id";
            using (SqlConnection dataConnection = new SqlConnection(ConnectionString))
            {
                dataConnection.Open();
                using (SqlCommand selectCommand = new SqlCommand(SelectOpskrift,dataConnection))
                {
                    selectCommand.Parameters.AddWithValue("@id", id);

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            return null;
                        }
                        reader.Read();

                        return MakeOpskrift(reader);
                    }
                }
            }

        }

        public void UpdateOpskrift(OpskriftClass opskriftClass)
        {
            const string updateOpskrift = "Update Opskrifter Set Titel=@Titel, Ingredienser=@Ingredienser, Opskrift=@Opskrift where Id=@id";
            using (SqlConnection dataConnection = new SqlConnection(ConnectionString))
            {
                dataConnection.Open();
                using (SqlCommand updateCommand = new SqlCommand(updateOpskrift, dataConnection))
                {
                    updateCommand.Parameters.AddWithValue("@id", opskriftClass.Id);
                    updateCommand.Parameters.AddWithValue("@Titel", opskriftClass.Titel);
                    updateCommand.Parameters.AddWithValue("@Ingredienser", opskriftClass.Ingredienser);
                    updateCommand.Parameters.AddWithValue("@Opskrift", opskriftClass.Opskrift);
                }
            }
        }

        public void DeleteOpskrift(int id)
        {
            const string deleteOpskrift = "Deletes from Opskrifter where Id = @id";
            using (SqlConnection dataConnection = new SqlConnection(ConnectionString))
            {
                dataConnection.Open();
                using (SqlCommand deleteCommand = new SqlCommand(deleteOpskrift, dataConnection))
                {
                    deleteCommand.Parameters.AddWithValue("@id", id);
                    deleteCommand.ExecuteNonQuery();
                }
            }
        }

        public string PostTemperatur(TemperaturClass temperaturClass)
        {
            throw new NotImplementedException();
        }

        public string ReadTemperatur(int id)
        {
            throw new NotImplementedException();
        }

        public string GetAvgTemperatur()
        {
            throw new NotImplementedException();
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }



        internal OpskriftClass MakeOpskrift(IDataRecord reader)
        {
            int id = reader.GetInt32(0);
            string titel = reader.GetString(1);
            string ingredienser = reader.GetString(2);
            string opskrift = reader.GetString(3);
            OpskriftClass tmpOpskrift = new OpskriftClass(id, titel, ingredienser, opskrift);
            return tmpOpskrift;
        }
    }
}
