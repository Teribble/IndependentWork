using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningDelegate
{
    public class Mage : BaseUnit
    {
        public Mage(string? name, float health): base(name, health) { }

        public void Decay(BaseUnit target)
        {
            target.Health -= 3;
            Console.WriteLine($"{target.Name} hp: " + target.Health);
        }

        public void ApplyDecayOnTarget(BaseUnit target)
        {
            target.unitStateChenger += Decay;
        }
    }
}
