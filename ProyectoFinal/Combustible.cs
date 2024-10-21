using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    internal class Combustible : Vehiculo
    {
        //Prop Privadas
        private string P_nombCombustible;

        //Constructores
        public Combustible(int IdCombustible, string Combustible) : base(IdCombustible)
        {
            this.nombCombustible = Combustible;
        }

        //Metodos
        public override void Editar()
        {
            Console.Write("Ingrese nuevo nombre para el combustible o 0 para salir: ");
            string opcion = Console.ReadLine();
            if (opcion != "0")
            {
                this.nombCombustible = opcion;
            }
        }
        public override string MostrarId()
        {
            return this.nombCombustible;
        }
        public override void MostrarMarSegComb()
        {
            Console.WriteLine("COMBUSTIBLE: {0} - {1}", idCombustible, nombCombustible);
        }

        //Prop publicas
        public string nombCombustible { get {  return this.P_nombCombustible; } set { this.P_nombCombustible = value; } }


    }
}
