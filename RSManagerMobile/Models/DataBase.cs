using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSManagerMobile.Models
{
    public class DataBase
    {
        private readonly SQLiteAsyncConnection _dataBase;

        public DataBase(string dbPath)
        {
            _dataBase = new SQLiteAsyncConnection(dbPath);
            _dataBase.CreateTableAsync<Autorization>().Wait();
            _dataBase.CreateTableAsync<Car>().Wait();
            _dataBase.CreateTableAsync<Client>().Wait();
            _dataBase.CreateTableAsync<Mechanic>().Wait();
            _dataBase.CreateTableAsync<Part>().Wait();
            _dataBase.CreateTableAsync<RepairShop>().Wait();
            _dataBase.CreateTableAsync<Work>().Wait();
        }

        public Task<List<Autorization>> GetUsers()
        {
            return _dataBase.Table<Autorization>().ToListAsync();
        }

        public Task<List<Car>> GetCars()
        {
            return _dataBase.Table<Car>().ToListAsync();
        }

        public Task<List<Client>> GetClietns()
        {
            return _dataBase.Table<Client>().ToListAsync();
        }

        public Task<List<Mechanic>> GetMechanics()
        {
            return _dataBase.Table<Mechanic>().ToListAsync();
        }

        public Task<List<Part>> GetParts()
        {
            return _dataBase.Table<Part>().ToListAsync();
        }

        public Task<List<RepairShop>> GetShops()
        {
            return _dataBase.Table<RepairShop>().ToListAsync();
        }

        public Task<List<Work>> GetWorks()
        {
            return _dataBase.Table<Work>().ToListAsync();
        }

        public Task<int> SaveItem(Autorization item)
        {
            if (item.Id != 0)
            {
                return _dataBase.UpdateAsync(item);
            }
            else
            {
                return _dataBase.InsertAsync(item);
            }
        }

        public Task<int> SaveItem(Car item)
        {
            if (item.Id != 0)
            {
                return _dataBase.UpdateAsync(item);
            }
            else
            {
                return _dataBase.InsertAsync(item);
            }
        }

        public Task<int> SaveItem(Client item)
        {
            if (item.Id != 0)
            {
                return _dataBase.UpdateAsync(item);
            }
            else
            {
                return _dataBase.InsertAsync(item);
            }
        }

        public Task<int> SaveItem(Mechanic item)
        {
            if (item.Id != 0)
            {
                return _dataBase.UpdateAsync(item);
            }
            else
            {
                return _dataBase.InsertAsync(item);
            }
        }

        public Task<int> SaveItem(Part item)
        {
            if (item.Id != 0)
            {
                return _dataBase.UpdateAsync(item);
            }
            else
            {
                return _dataBase.InsertAsync(item);
            }
        }

        public Task<int> SaveItem(RepairShop item)
        {
            if (item.Id != 0)
            {
                return _dataBase.UpdateAsync(item);
            }
            else
            {
                return _dataBase.InsertAsync(item);
            }
        }

        public Task<int> SaveItem(Work item)
        {
            if (item.Id != 0)
            {
                return _dataBase.UpdateAsync(item);
            }
            else
            {
                return _dataBase.InsertAsync(item);
            }
        }

        public Task<int> RemoveItem(Autorization item)
        {
            return _dataBase.DeleteAsync(item);
        }

        public Task<int> RemoveItem(Car item)
        {
            return _dataBase.DeleteAsync(item);
        }

        public Task<int> RemoveItem(Client item)
        {
            return _dataBase.DeleteAsync(item);
        }

        public Task<int> RemoveItem(Mechanic item)
        {
            return _dataBase.DeleteAsync(item);
        }

        public Task<int> RemoveItem(Part item)
        {
            return _dataBase.DeleteAsync(item);
        }

        public Task<int> RemoveItem(RepairShop item)
        {
            return _dataBase.DeleteAsync(item);
        }

        public Task<int> RemoveItem(Work item)
        {
            return _dataBase.DeleteAsync(item);
        }

    }
}
