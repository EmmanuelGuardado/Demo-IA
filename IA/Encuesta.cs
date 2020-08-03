using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IA
{
    public class Encuesta: IEquatable<Encuesta>
    {
        public string Clima { get; set; }
        public bool Cultura { get; set; }
        public bool Montañas { get; set; }
        public bool Playa { get; set; }
        public bool Animales { get; set; }
        public bool Bosque { get; set; }
        public bool Acampar { get; set; }

        public bool Equals(Encuesta e)
        {
            if (this.Clima.Equals(e.Clima))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
