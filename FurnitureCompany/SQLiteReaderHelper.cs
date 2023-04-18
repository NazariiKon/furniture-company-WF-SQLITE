using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FurnitureCompany
{
    internal class SQLiteReaderHelper
    {

        public static List<T> readObjects<T>(SQLiteDataReader reader, Func<SQLiteDataReader, T> createObject)
        {
            var objects = new List<T>();
            while (reader.Read())
            {
                var obj = createObject(reader);
                objects.Add(obj);
            }
            return objects;
        }

        public static T CreateObject<T>(SQLiteDataReader reader, params object[] args) where T : new()
        {
            T obj = new T();
            Type type = typeof(T);
            for (int i = 0; i < args.Length; i++)
            {
                PropertyInfo prop = type.GetProperty(args[i].ToString());
                if (prop != null)
                {
                    prop.SetValue(obj, reader.GetValue(i));
                }
            }
            return obj;
        }
        public static SQLiteDataReader Request(string query, params object[] args)
        {
            SQLiteConnection _con = new SQLiteConnection(@"Data Source=furniture.db");
            _con.Open();
            SQLiteCommand command = new SQLiteCommand(query, _con);
            if (args.Length > 0)
            {
                string pattern = @"@\w+"; // регулярное выражение для поиска всех слов, начинающихся с "@"
                MatchCollection matches = Regex.Matches(query, pattern);
                string[] paramNames = new string[matches.Count];
                for (int i = 0; i < matches.Count; i++)
                    paramNames[i] = matches[i].Value;

                for (int i = 0; i < args.Length; i++)
                {
                    command.Parameters.AddWithValue(paramNames[i], args[i]);
                }
            }
            SQLiteDataReader reader = command.ExecuteReader();

            if (reader.HasRows) // если есть данные
            {
                return reader;
            }
            else
            {
                return null;
            }
        }
    }
}
