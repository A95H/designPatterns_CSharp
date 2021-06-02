using System;

namespace SingletonPattern.Singleton
{
    public class Database
    {
        private static Database instance;
        public static Database getInstance()
        {
            if (instance == null)
            {
                instance = new Database();
            }
            return instance;

        }
        public void query(string sql)
        {
            Console.WriteLine("Executing " + sql);
        }
    }
}