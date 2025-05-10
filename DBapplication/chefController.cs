using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace DBapplication
{
    public class chefController
    {
       
        DBManager dbMan;
        public chefController()
        {
            dbMan = new DBManager();
        }


        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
        public int ShareRecipe(string title, string genre, int authid)
        {
            //string query = @"INSERT INTO Book (Title, Genre, AuthorID)" + "Values('" + title + "', '" + genre + "' ,'" + authid + "' );";
            string query = $@"INSERT INTO Recipe (Name, Description, Steps, Photo, Difficulty_Level, NutritionalInfo, Cooking_Time, ChefID )
                              values()";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable veiwrecipes()
        {
            string query = "SELECT * FROM Recipe ORDER BY Name DESC ";
            return dbMan.ExecuteReader(query);
        }


    }
}
