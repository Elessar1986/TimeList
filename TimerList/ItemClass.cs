using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimerList
{
    public class ItemClass
    {
        public string Name { get; set; }
        public string timeCreated { get; set; }

        public ItemClass(string name)
        {
            Name = name;
            timeCreated = DateTime.Now.ToLongTimeString();
            Console.WriteLine(this);
        }

        public override string ToString()
        {
            return $"Object name: {Name}. Created at: {timeCreated}.";
        }
    }
}
