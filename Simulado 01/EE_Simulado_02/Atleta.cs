using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EE_Simulado_02
{
    public class Atleta
    {
        private string name = "";
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int peso;
        public int Peso
        {
            get { return peso; }
            set { peso = value; }
        }
        
        
    }
}