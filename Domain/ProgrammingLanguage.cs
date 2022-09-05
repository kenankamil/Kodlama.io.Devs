using Core.Persistence.Repositories;

namespace Domain
{
    public class ProgrammingLanguage : Entity
    {
        public string Name { get; set; }

        public ProgrammingLanguage()
        {
        }

        public ProgrammingLanguage(int id, string name) : this()
        {
            Id = id;
            Name = name;
        }
    }
}