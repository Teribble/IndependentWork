using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningDelegate
{
    public class Warrior : BaseUnit
    {
        public Warrior(string? name, float health) : base(name, health)
        {
        }

        public void Hit(BaseUnit target)
        {
            target.Health -= 10;
            Console.WriteLine($"{target.Name} hp: " + target.Health);
        }

        public void ApplyHitInTarget(BaseUnit target)
        {
            target.unitStateChenger += Hit;
        }
    }
}
