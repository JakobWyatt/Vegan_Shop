using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Vegan_Shop;
using SQLite;

namespace Vegan_Shop_Test
{
    public class FoodDatabaseTestSync : IFoodDatabase
    {
        private readonly String dbPath;
        private readonly SQLiteConnection connection;

        public FoodDatabaseTestSync()
        {
            dbPath = Path.Combine(Environment.GetFolderPath(
                Environment.SpecialFolder.LocalApplicationData), "FoodTestSyncSQLite.db3");
            connection = new SQLiteConnection(dbPath);
        }

        public void Update()
        {
            //Fill with test data
            connection.DropTable<Food>();
            connection.CreateTable<Food>();
            connection.InsertAll((IEnumerable<Food>)TestData.TestFood);
        }

        public Task<List<Food>> GetFoods() => Task.FromResult(connection.Table<Food>().ToList());
    }
}
