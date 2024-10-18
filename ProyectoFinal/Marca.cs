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
        private string P_marca;

        //Constructores
        public Marca (int IdMarca, string Marca) : base(IdMarca)
        {
            this.marca = Marca;
        }

        //Metodos
        public void EditarMarca()
        {
            Console.Write("Ingrese nuevo nombre: ");
            this.marca = Console.ReadLine();
        }
        public override string MostrarId()
        {
            return this.marca;
        }
        public override void MostrarMarSegComb()
        {
            Console.WriteLine("MARCA: {0} - {1}", idMarca, marca);
        }

        //Prop publicas
        public string marca { get { return this.P_marca; } set { this.P_marca = value; } }

    }
}
