using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    internal class Camion : Vehiculo
    {
        //Prop Privadas


        //Constructores
        public Camion(int Idvehiculo, int Idmarca, int Idsegmento, int Idcombustible,
                         string Patente, int Kilometros, int Anio, string Modelo, float Preciovta,
                         string Observaciones, string Color, int Cilindrada, bool CajaCarga, int DimensionCaja, int CargaMax) :
                     base(Idvehiculo, Idmarca, Idsegmento, Idcombustible,
                          Patente, Kilometros, Anio, Modelo, Preciovta,
                          Observaciones, Color, Cilindrada, CajaCarga)
                         {
                            this.dimensionCaja = DimensionCaja;
                            this.cargaMax = CargaMax;
                         }
        //Metodos
        public override void MostrarVehiculo(string marca, string segmento, string combustible, string caja)
        {
            Console.WriteLine("CAMION: {0} - {1} - {2} - {3} - {4} - {5} - {6} - {7} - {8} - {9} - {10} - {11} - {12} - {13} - {14}", 
                    idVehiculo, marca, segmento, combustible,
                    patente, kilometros, anio, modelo, precioVta,
                    observaciones, color, cilindrada, caja, dimensionCaja, cargaMax);
        }
    }
}
