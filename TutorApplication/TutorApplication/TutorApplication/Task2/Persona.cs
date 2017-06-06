using System;

namespace TutorApplication
{
    public class Persona : IAttackProvider,IAttackTarget
    {
        private PersonaStats _stats;

        public Persona(PersonaStats stats)
        {
            _stats = stats;
        }
        public Damage Provide()
        {
            return new Damage();
        }

        public void Apply(Damage damage)
        {

        }
    }
}