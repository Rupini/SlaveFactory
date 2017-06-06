using System;

namespace TutorApplication
{
    public interface IAttackTarget
    {
        void Apply(Damage damage);  
    }
}