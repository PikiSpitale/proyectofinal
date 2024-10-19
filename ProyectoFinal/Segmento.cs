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
        private string P_nombSegmento;

        //Constructores
        public Segmento(int IdSegmento, string Segmento) : base(IdSegmento)
        {
            this.nombSegmento = Segmento;
        }

        //Metodos
        public override void Editar()
        {
            Console.Write("Ingrese nuevo nombre para el segmento: ");
            this.nombSegmento = Console.ReadLine();
        }
        public override string MostrarId()
        {
            return this.nombSegmento;
        }

        public override void MostrarMarSegComb()
        {
            Console.WriteLine("SEGMENTO: {0} - {1}", idSegmento, nombSegmento);
        }
        //Prop publicas
        public string nombSegmento { get { return this.P_nombSegmento; } set { this.P_nombSegmento = value; } }
    }
}
