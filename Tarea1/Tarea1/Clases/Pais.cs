using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1.Clases
{
    public class Pais
    {
        //se crean variables las cuales van a ser heredado a otra clase "CostaRica"
        public virtual string Panama()
        {
            return "un país es Panamá";
        }
        
        //se crea un string el cual va a ser heredado a otra clase "CostaRica" y además se usará un override para modificarlo
        public virtual string costaRicaPais(){
            return "esto se modificará";
        }

    }
}
