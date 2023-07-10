using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Examen.Controllers
{
    public class DataBase
    {
        readonly SQLiteAsyncConnection _connection;

        public DataBase() { }

        public DataBase(string path) 
        { 
            _connection = new SQLiteAsyncConnection(path);

            _connection.CreateTableAsync<Models.Personas>().Wait();

        }

        public Task <int> AddPersona(Models.Personas persona)
        {
            if (persona.id == 0)
            {
                return _connection.InsertAsync(persona);
            }
            else
            {
                return _connection.UpdateAsync(persona);
            }
        }

        public Task<List<Models.Personas>> GetAllPersonas()
        {
            return _connection.Table<Models.Personas>().ToListAsync();
        }

        public Task<Models.Personas> GetPersonas(int pid) 
        {
            return _connection.Table<Models.Personas>().Where(i=>i.id == pid ).FirstOrDefaultAsync();
        }

        public Task<int> DeletePersona(Models.Personas personas)
        {
            return _connection.DeleteAsync(personas);
        }
    }
}
