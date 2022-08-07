using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCNPM
{
    public class PhongThi
    {
        private string name;
        public string Name { get => name; set => name = value; }
        public PhongThi(string name)
        {
            this.Name = name;
        }
    }
}
