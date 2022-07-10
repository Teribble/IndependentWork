using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningDelegate
{
    public class BaseUnit
    {
        public string? Name { get; set; }
        public float Health { get; set; }

        public delegate void UnitStateChenger(BaseUnit baseUnit);

        public UnitStateChenger? unitStateChenger;

        public BaseUnit(string? name, float health)
        {
            Name = name;

            Health = health;
        }
        public void EndOfMove()
        {
            unitStateChenger?.Invoke(this);
        }
    }
}
