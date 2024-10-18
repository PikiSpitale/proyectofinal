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
        private string P_combustible;

        //Constructores
        public Combustible(int IdCombustible, string Combustible) : base(IdCombustible)
        {
            this.combustible = Combustible;
        }

        //Metodos
        public override string MostrarId()
        {
            return this.combustible;
        }
        public override void MostrarMarSegComb()
        {
            Console.WriteLine("COMBUSTIBLE: {0} - {1}", idCombustible, combustible);
        }

        //Prop publicas
        public string combustible { get {  return this.P_combustible; } set { this.P_combustible = value; } }


    }
}
