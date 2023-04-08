using LabW03JesseArnold.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace LabW03JesseArnold.Services
{
    public class DbPersonRepository : IPersonRepository
    {
        private ApplicationDbContext _dataBaseContext;

        public DbPersonRepository(ApplicationDbContext dataBaseContext)
        {
            _dataBaseContext = dataBaseContext;
        }

        public Person Create(Person person)
        {
            _dataBaseContext.People.Add(person);
            _dataBaseContext.SaveChanges();
            return person;
        
        }

        public ICollection<Person> ReadAll()
        {
            return _dataBaseContext.People.ToList();
        }
    }
}
