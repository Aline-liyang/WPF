using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls.Primitives;

namespace WpfDataBase
{
    public static class Crud
    {
        public static ObservableCollection<Employe> GetListEmployes(SqlConnection connection)
        {

            ObservableCollection<Employe> employes = new ObservableCollection<Employe>();

            string requete = @"Select * from employe;";

            // Exécute une commande sur une source de données
            SqlCommand cmd = new SqlCommand(requete, connection);
            // Lit un flux de données en lecture seule à partir d'une source de données.
            SqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                employes.Add(new Employe()
                {
                    EmployeId = dataReader.GetInt32(0),
                    Nom = dataReader.GetString(1),
                    Prenom = dataReader.GetString(2),
                    DateNaissance = dataReader.GetDateTime(3),
                    Adresse = dataReader.GetString(4),
                    Telephone = dataReader.GetString(5),
                    Extension = dataReader.GetString(6),
                    Courriel = dataReader.GetString(7),
                });
            }

            dataReader.Close();
            return employes;
        }

        public static bool Supprimer(int EmpID, SqlConnection connection)
        {
            string requete = @"Delete Employe Where EmployeID = @EmployeID;";
            SqlCommand cmd = new SqlCommand(requete, connection);

            cmd.Parameters.AddWithValue("@EmployeID", EmpID);

            return (cmd.ExecuteNonQuery() > 0);

        }

        public static bool Ajouter(Employe employe, SqlConnection connection)
        {
            string requete = @"INSERT Employe(Nom,Prenom,DateNaissance, Adresse, Telephone, Extension, Courriel)
                              VALUES (@Nom, @Prenom, @DateNaissance, @Adresse, @Telephone, @Extension, @Courriel);";

            try
            {
                SqlCommand cmd = new SqlCommand(requete, connection);

                cmd.Parameters.AddWithValue("@Nom", employe.Nom);
                cmd.Parameters.AddWithValue("@Prenom", employe.Prenom);
                cmd.Parameters.AddWithValue("@DateNaissance", employe.DateNaissance);
                cmd.Parameters.AddWithValue("@Adresse", employe.Adresse);
                cmd.Parameters.AddWithValue("@Telephone", employe.Telephone);
                cmd.Parameters.AddWithValue("@Extension", employe.Extension);
                cmd.Parameters.AddWithValue("@Courriel", employe.Courriel);

                return cmd.ExecuteNonQuery() > 0;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        public static bool Modifier(Employe employe, SqlConnection connection)
        {
            string requete = @"UPDATE Employe SET Nom = @Nom,
                                                  Prenom = @Prenom,
                                                  DateNaissance = @DateNaissance, 
                                                  Adresse = @Adresse, 
                                                  Telephone = @Telephone, 
                                                  Extension = @Extension, 
                                                  Courriel = @Courriel 
                                                  WHERE EmployeId = @EmployeId;";

            try
            {
                SqlCommand cmd = new SqlCommand(requete, connection);

                cmd.Parameters.AddWithValue("@EmployeId", employe.EmployeId);
                cmd.Parameters.AddWithValue("@Nom", employe.Nom);
                cmd.Parameters.AddWithValue("@Prenom", employe.Prenom);
                cmd.Parameters.AddWithValue("@DateNaissance", employe.DateNaissance);
                cmd.Parameters.AddWithValue("@Adresse", employe.Adresse);
                cmd.Parameters.AddWithValue("@Telephone", employe.Telephone);
                cmd.Parameters.AddWithValue("@Extension", employe.Extension);
                cmd.Parameters.AddWithValue("@Courriel", employe.Courriel);

                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;

        }

        public static int GetLastRecord(SqlConnection connection)
        {
            //string requete = @"Select EmployeID from Employe Where EmployeID = (Select max(EmployeID) From Employe);";
            string requete = @"SELECT IDENT_CURRENT('Employe');";
                
            SqlCommand cmd = new SqlCommand(requete, connection);

            SqlDataReader dataReader = cmd.ExecuteReader();

            if( dataReader.Read())
            {
                int employeId =   Int32.Parse(dataReader.GetValue(0).ToString());
                dataReader.Close();
                return employeId;
            }
            return -1;
        }
    }
}
