using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    internal class Segmento : Vehiculo
    {
        //Prop Privadas
        private string P_segmento;

        //Constructores
        public Segmento(int IdSegmento, string Segmento) : base(IdSegmento)
        {
            this.segmento = Segmento;
        }

        //Metodos
        public override string MostrarId()
        {
            return this.segmento;
        }

        public override void MostrarMarSegComb()
        {
            Console.WriteLine("SEGMENTO: {0} - {1}", idSegmento, segmento);
        }
        //Prop publicas
        public string segmento { get { return this.P_segmento; } set { this.P_segmento = value; } }
    }
}
