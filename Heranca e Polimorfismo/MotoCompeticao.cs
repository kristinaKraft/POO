using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class MotoCompeticao : Moto
    {
        public int NumeroCompetidor { get; set; }
        public string ToString()
        {
            return $"{base.ToString()} Competidor:{NumeroCompetidor} ";
        }

        public MotoCompeticao() { }

        public MotoCompeticao(string marca, int cilindradas, int numeroCompetidor) : base(marca, cilindradas)
        {
            NumeroCompetidor = numeroCompetidor;
        }
    }
}