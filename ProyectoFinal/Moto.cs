using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    internal class Moto : Vehiculo
    {

        //Constructores
        public Moto(int Idvehiculo, int Idmarca, int Idsegmento, int Idcombustible,
                         string Patente, int Kilometros, int Anio, string Modelo, float Preciovta,
                         string Observaciones, string Color, int Cilindrada, bool CajaCarga) :
                     base(Idvehiculo, Idmarca, Idsegmento, Idcombustible,
                          Patente, Kilometros, Anio, Modelo, Preciovta,
                          Observaciones, Color, Cilindrada, CajaCarga){ }

        //Metodo
        public override void Editar()
        {
            bool cond = true;
            int opcion;
            while (cond)
            {
                Console.WriteLine("Ingrese la opcion que desea editar");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("1- Id marca");
                Console.WriteLine("2- Id segmento");
                Console.WriteLine("3- Id combustible");
                Console.WriteLine("4- Patente");
                Console.WriteLine("5- Kilometros");
                Console.WriteLine("6- Año");
                Console.WriteLine("7- Modelo");
                Console.WriteLine("8- Precio");
                Console.WriteLine("9- Observaciones");
                Console.WriteLine("10- Color");
                Console.WriteLine("11- Cilindrada");
                Console.WriteLine("12- Caja de carga");
                Console.WriteLine();
                Console.WriteLine("0- Salir");
                Console.WriteLine("----------------------------------");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese nueva id de marca:");
                        this.idMarca = int.Parse(Console.ReadLine());
                        break;
                    case 2:
                        Console.Write("Ingrese nueva id de segmento:");
                        this.idSegmento = int.Parse(Console.ReadLine());
                        break;
                    case 3:
                        Console.Write("Ingrese nueva id de combustible:");
                        this.idCombustible = int.Parse(Console.ReadLine());
                        break;
                    case 4:
                        Console.Write("Ingrese nueva patente:");
                        this.patente = Console.ReadLine();
                        break;
                    case 5:
                        Console.Write("Ingrese nuevos kilometros:");
                        this.kilometros = int.Parse(Console.ReadLine());
                        break;
                    case 6:
                        Console.Write("Ingrese nuevo año:");
                        this.anio = int.Parse(Console.ReadLine());
                        break;
                    case 7:
                        Console.Write("Ingrese nuevo modelo:");
                        this.modelo = Console.ReadLine();
                        break;
                    case 8:
                        Console.Write("Ingrese precio:");
                        this.precioVta = int.Parse(Console.ReadLine());
                        break;
                    case 9:
                        Console.Write("Ingrese nuevas observaciones:");
                        this.observaciones = Console.ReadLine();
                        break;
                    case 10:
                        Console.Write("Ingrese nuevo color:");
                        this.color = Console.ReadLine();
                        break;
                    case 11:
                        Console.Write("Ingrese nueva cilindrada:");
                        this.cilindrada = int.Parse(Console.ReadLine());
                        break;
                    case 12:
                        Console.Write("Ingrese nueva caja de carga:");
                        this.cajaCarga = Concesionaria.Booleano(Console.ReadLine());
                        break;
                    case 0:
                        cond = false;
                        break;
                    default:
                        Console.WriteLine("Ingrese opcion correcta");
                        Console.WriteLine("Enter para continuar");
                        break;
                }
                Console.Clear();
            }

        }
        public override void MostrarVehiculo(string marca, string segmento, string combustible,string caja)
        {
            Console.WriteLine("MOTO: {0} - {1} - {2} - {3} - {4} - {5} - {6} - {7} - {8} - {9} - {10} - {11} - {12}", 
                    idVehiculo, marca, segmento, combustible,
                    patente, kilometros, anio, modelo, precioVta,
                    observaciones, color, cilindrada, caja);
        }
    }
}
