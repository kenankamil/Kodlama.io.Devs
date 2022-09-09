using Core.Persistence.Repositories;

namespace Domain
{
    public class Technology : Entity
    {

        public string Name { get; set; }
        public int ProgrammingLanguageId { get; set; }
        public virtual ProgrammingLanguage ProgrammingLanguage { get; set; }


        public Technology()
        {

        }

        public Technology(string name, int programmingLanguageId) : this()
        {
            Name = name;
            ProgrammingLanguageId = programmingLanguageId;
        }
    }
}