using LabW03JesseArnold.Models.Entities;

namespace LabW03JesseArnold.Services
{
    public interface IPersonRepository
    {
        public ICollection<Person> ReadAll();
        public Person Create(Person person);
       

    }
}
