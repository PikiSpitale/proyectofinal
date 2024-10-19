using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    internal class Marca : Vehiculo
    {
        //Prop Privadas
        private string P_nombMarca;

        //Constructores
        public Marca (int IdMarca, string Marca) : base(IdMarca)
        {
            this.nombMarca = Marca;
        }

        //Metodos
        public override void Editar()
        {
            Console.Write("Ingrese nuevo nombre para la marca: ");
            this.nombMarca = Console.ReadLine();
        }
        public override string MostrarId()
        {
            return this.nombMarca;
        }
        public override void MostrarMarSegComb()
        {
            Console.WriteLine("MARCA: {0} - {1}", idMarca, nombMarca);
        }

        //Prop publicas
        public string nombMarca { get { return this.P_nombMarca; } set { this.P_nombMarca = value; } }

    }
}
