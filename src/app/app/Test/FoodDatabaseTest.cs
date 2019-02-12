using System;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Generic;
using Vegan_Shop;
using SQLite;

namespace Vegan_Shop_Test
{
    public class FoodDatabaseTest : IFoodDatabase
    {
        private readonly String dbPath;
        private readonly SQLiteAsyncConnection connection;

        public FoodDatabaseTest()
        {
            dbPath = Path.Combine(Environment.GetFolderPath(
                Environment.SpecialFolder.LocalApplicationData), "FoodTestSQLite.db3");
            connection = new SQLiteAsyncConnection(dbPath);
        }

        public async void Update()
        {
            //Fill with test data
            await connection.DropTableAsync<Food>();
            await connection.CreateTableAsync<Food>();
            await connection.InsertAllAsync((IEnumerable<Food>)TestData.TestFood);
        }

        public async Task<List<Food>> GetFoods() => await connection.Table<Food>().ToListAsync();
    }
}
