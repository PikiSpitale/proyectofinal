using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    internal class Auto : Vehiculo
    {        
        //Prop Privadas
        

        //Constructores
        public Auto(int Idvehiculo, int Idmarca, int Idsegmento, int Idcombustible,
                         string Patente, int Kilometros, int Anio, string Modelo, float Preciovta,
                         string Observaciones, string Color, int Cilindrada, bool CajaCarga) : 
                base(Idvehiculo, Idmarca, Idsegmento, Idcombustible, 
                    Patente, Kilometros, Anio, Modelo, Preciovta,
                    Observaciones, Color, Cilindrada, CajaCarga){ }



        //Metodos

        public override void Editar()
        {
            bool cond = true;
            int opcion;
            while (cond)
            {
                Console.WriteLine("Ingrese la opcion para editar");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("1- Id marca");
                Console.WriteLine("2- Id segmento");
                Console.WriteLine("3- Id combustible");
                Console.WriteLine("4- Kilometros");
                Console.WriteLine("5- Año");
                Console.WriteLine("6- Modelo");
                Console.WriteLine("7- Precio");
                Console.WriteLine("8- Observaciones");
                Console.WriteLine("9- Color");
                Console.WriteLine("10- Cilindrada");
                Console.WriteLine("11- Caja de carga");
                Console.WriteLine();
                Console.WriteLine("0- Salir");
                Console.WriteLine("----------------------------------");
                opcion = Console.Read();
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese nueva id de marca:");
                        this.idMarca = Console.Read();
                        break;
                    case 2:
                        Console.WriteLine("Ingrese nueva id de segmento:");
                        this.idSegmento = Console.Read();
                        break;
                    case 3:
                        Console.WriteLine("Ingrese nueva id de combustible:");
                        this.idCombustible = Console.Read();
                        break;
                    case 4:
                        Console.WriteLine("Ingrese nuevos kilometros:");
                        this.kilometros = Console.Read();
                        break;
                    case 5:
                        Console.WriteLine("Ingrese nuevo año:");
                        this.anio = ;
                        break;
                    case 6:
                        Console.WriteLine("Ingrese nuevo modelo:");
                        this.modelo = Console.Read();
                        break;
                    case 7:
                        Console.WriteLine("Ingrese precio:");
                        this.idMarca = Console.Read();
                        break;
                    case 8:
                        Console.WriteLine("Ingrese nueva id de marca:");
                        this.idMarca = Console.Read();
                        break;
                    case 9:
                        Console.WriteLine("Ingrese nueva id de marca:");
                        this.idMarca = Console.Read();
                        break;
                    case 10:
                        Console.WriteLine("Ingrese nueva id de marca:");
                        this.idMarca = Console.Read();
                        break;
                    case 11:
                        Console.WriteLine("Ingrese nueva id de marca:");
                        this.idMarca = Console.Read();
                        break;
                    case 12:
                        Console.WriteLine("Ingrese nueva id de marca:");
                        this.idMarca = Console.Read();
                        break;
                    case 0:
                        cond = false;
                        break;

                }
            }
            
        }

        public override void MostrarVehiculo(string marca, string segmento, string combustible, string caja)
        {
            Console.WriteLine("AUTO: {0} - {1} - {2} - {3} - {4} - {5} - {6} - {7} - {8} - {9} - {10} - {11} - {12}", 
                    idVehiculo, marca, segmento, combustible,
                    patente, kilometros, anio, modelo, precioVta,
                    observaciones, color, cilindrada, caja);
        }

        //Prop publicas



    }
}
