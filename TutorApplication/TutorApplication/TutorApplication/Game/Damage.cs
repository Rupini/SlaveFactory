using TutorApplication.Task2API;

namespace TutorApplication
{
    public class Damage : IDamage
    {
        public IDamageProvider Owner { get; }

        public Damage(IDamageProvider owner)
        {
            Owner = owner;
        }
    }
}