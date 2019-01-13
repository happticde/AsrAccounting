using AsrAccounting.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsrAccounting.ViewModel {
    public class DbHelper {
        private static readonly string dbFile = Path.Combine(Environment.CurrentDirectory, "historyInput.db");

        public static List<Customer> SearchCustomer(string searchString) {
            List<Customer> result = new List<Customer>();

            using (SQLiteConnection connection = new SQLiteConnection(dbFile)) {
                connection.CreateTable<Customer>();
                result = (from c in connection.Table<Customer>()
                          where c.Name.ToLower().Contains(searchString.ToLower())
                          select c).ToList();
            }

            return result;
        }

        public static List<T> ReadAll<T>() where T : new(){
            List<T> result = new List<T>();

            using (SQLiteConnection connection = new SQLiteConnection(dbFile)) {
                connection.CreateTable<T>();
                result = connection.Table<T>().ToList();
            }

            return result;
        }

        public static bool Insert<T>(T entity) {
            int affectedRows = 0;

            using(SQLiteConnection connection = new SQLiteConnection(dbFile)) {
                connection.CreateTable<T>();
                affectedRows = connection.Insert(entity);
            }

            return affectedRows != 0;
        }

        public static bool Update<T>(T entity) {
            int affectedRows = 0;

            using (SQLiteConnection connection = new SQLiteConnection(dbFile)) {
                connection.CreateTable<T>();
                affectedRows = connection.Update(entity);
            }

            return affectedRows != 0;
        }

        public static bool Delete<T>(T entity) {
            int affectedRows = 0;

            using (SQLiteConnection connection = new SQLiteConnection(dbFile)) {
                connection.CreateTable<T>();
                affectedRows = connection.Delete(entity);
            }

            return affectedRows != 0;
        }
    }
}
