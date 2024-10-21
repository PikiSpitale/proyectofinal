using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Auto auto = new Auto(1, 3, 4, 5, "739 ABC", 23423434, 2007, "Fiat", 3824, "Nada", "Rojo", 2, false);
            Camion camion = new Camion(4, 3, 4, 5, "739 ABC", 23423434, 2007, "Fiat", 3824, "Nada", "Rojo", 2, false, 23, 54);
            Moto moto = new Moto(3, 3, 4, 5, "739 ABC", 23423434, 2007, "Fiat", 3824, "Nada", "Rojo", 2, false);
            Marca marca = new Marca(1, "Audi");
            Combustible combustible = new Combustible(2, "Nafta");
            Segmento segmento = new Segmento(3, "Pick-Up");
            
            

            Concesionaria con = new Concesionaria();

            //---------- MARCAS -------------
            //---------- SEGMENTOS ----------
            //---------- COMBUSTIBLES -------
            
            string marcasTxt = "marcas.txt";
            string segmentosTxt = "segmentos.txt";
            string combustiblesTxt = "combustibles.txt";
            string autosTxt = "autos.txt";
            string motosTxt = "motos.txt";
            string camionesTxt = "camiones.txt";

            con.CargarListas(marcasTxt);
            con.CargarListas(segmentosTxt);
            con.CargarListas(combustiblesTxt);
            con.CargarListas(autosTxt);
            con.CargarListas(motosTxt);
            con.CargarListas(camionesTxt);


          
            //**********************CARGAR**************************
            bool cond = true;
            while (cond) { 
            con.CargarMarca();
            Console.WriteLine("desea continuar? ");
            int nashe = int.Parse(Console.ReadLine());
            Console.Clear();
                if (nashe == 0) {
                    cond = false;  
                }
            
            }
            cond = true;
            while (cond)
            {
                con.CargarSegmento();
                Console.WriteLine("desea continuar? ");
                int nashe = int.Parse(Console.ReadLine());
                Console.Clear();
                if (nashe == 0)
                {
                    cond = false;
                }

            }
            cond = true;
            while (cond)
            {
                con.CargarCombustible();
                Console.WriteLine("desea continuar? ");
                int nashe = int.Parse(Console.ReadLine());
                Console.Clear();
                if (nashe == 0)
                {
                    cond = false;
                }

            }
            cond = true;
            while (cond)
            {
                con.CargarAuto();
                Console.WriteLine("desea continuar? ");
                int nashe = int.Parse(Console.ReadLine());
                Console.Clear();
                if (nashe == 0)
                {
                    cond = false;
                }

            }
            cond = true;
            while (cond)
            {
                con.CargarMoto();
                Console.WriteLine("desea continuar? ");
                int nashe = int.Parse(Console.ReadLine());
                Console.Clear();
                if (nashe == 0)
                {
                    cond = false;
                }

            }
            cond = true;
            while (cond)
            {
                con.CargarCamion();
                Console.WriteLine("desea continuar? ");
                int nashe = int.Parse(Console.ReadLine());
                Console.Clear();
                if (nashe == 0)
                {
                    cond = false;
                }

            }
            //********************LISTADO(MEJORAR NOMBRES)**********

            Console.WriteLine("----------MARCAS------------");
            con.MostrarMarcas();
            Console.WriteLine("---------SEGMENTOS----------");
            con.MostrarSegmentos();
            Console.WriteLine("-------COMBUSTIBLES---------");
            con.MostrarCombustibles();
            Console.WriteLine("-----------AUTOS------------");
            con.MostrarAutos();
            Console.WriteLine("-----------MOTOS------------");
            con.MostrarMotos();
            Console.WriteLine("---------CAMIONES-----------");
            con.MostrarCamiones();
            Console.ReadKey();
            Console.Clear();
            //*********************EDICION**************************

            con.EditarMarca();
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("----------MARCAS------------");
            con.MostrarMarcas();
            Console.ReadKey();
            Console.Clear();

            con.EditarSegmento();
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("-------SEGMENTOS---------");
            con.MostrarSegmentos();
            Console.ReadKey();
            Console.Clear();

            con.EditarCombustible();
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("-------COMBUSTIBLES---------");
            con.MostrarCombustibles();
            Console.ReadKey();
            Console.Clear();

            con.EditarAuto();
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("-----------AUTOS------------");
            con.MostrarAutos();
            Console.ReadKey();
            Console.Clear();

            con.EditarCamion();
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("---------CAMIONES-----------");
            con.MostrarCamiones();
            Console.ReadKey();
            Console.Clear();

            con.EditarMoto();
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("-----------MOTOS------------");
            con.MostrarMotos();
            Console.ReadLine();
            Console.Clear();
            

            //*********************BORRAR**************************

            Console.WriteLine("-----------MARCAS------------");
            con.MostrarMarcas();
            Console.ReadKey();
            Console.Clear();
            con.BorrarMarca();
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("-----------MARCAS------------");
            con.MostrarMarcas();
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("-----------SEGMENTOS------------");
            con.MostrarSegmentos();
            Console.ReadKey();
            Console.Clear();
            con.BorrarSegmento();
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("-----------SEGMENTOS------------");
            con.MostrarSegmentos();
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("-----------COMBUSTIBLES------------");
            con.MostrarCombustibles();
            Console.ReadKey();
            Console.Clear();
            con.BorrarCombustible();
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("-----------COMBUSTIBLES------------");
            con.MostrarCombustibles();
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("-----------AUTOS------------");
            con.MostrarAutos();
            Console.ReadKey();
            Console.Clear();
            con.BorrarAuto();
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("-----------AUTOS------------");
            con.MostrarAutos();
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("-----------CAMIONES------------");
            con.MostrarCamiones();
            Console.ReadKey();
            Console.Clear();
            con.BorrarCamion();
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("-----------CAMIONES------------");
            con.MostrarCamiones();
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("-----------MOTOS------------");
            con.MostrarMotos();
            Console.ReadKey();
            Console.Clear();
            con.BorrarMoto();
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("-----------MOTOS------------");
            con.MostrarMotos();
            Console.ReadKey();
            Console.Clear();

            /*
            _.-="_-         _
                         _.-="   _-          | ||"""""""---._______     __..
             ___.===""""-.______-,,,,,,,,,,,,`-''----" """""       """""  __'
      __.--""     __        ,'                   o \           __        [__|
 __-""=======.--""  ""--.=================================.--""  ""--.=======:
]       [w] : /        \ : |========================|    : /        \ :  [w] :
V___________:|          |: |========================|    :|          |:   _-"
 V__________: \        / :_|=======================/_____: \        / :__-"
 -----------'  "-____-"  `-------------------------------'  "-____-"
            */

        }
        /*
        public static void Menu()
        {
            string[] menuopciones = { "Marcas", "Segmentos", "Combustibles", "Vehiculos", "Clientes", "Salir" };
            string[] submenu = { "Crear", "Leer", "Modificar", "Eliminar" };
            int i = 0;
            int j = 0;
            bool cond = true;
            Console.WriteLine("Seleccione una opcion");
            Console.WriteLine("-------------------------------------");

            Console.WriteLine(" > " + menuopciones[i]);
            Console.WriteLine(menuopciones[i + 1]);
            Console.WriteLine(menuopciones[i + 2]);
            Console.WriteLine(menuopciones[i + 3]);
            Console.WriteLine(menuopciones[i + 4]);
            Console.WriteLine(menuopciones[i + 5]);

            ConsoleKeyInfo tecla = Console.ReadKey();

            Console.Clear();
            while (cond == true)
            {
                if (tecla.Key == ConsoleKey.DownArrow)
                {
                    if (i == 0)
                    {
                        Console.WriteLine("Seleccione una opcion");
                        Console.WriteLine("-------------------------------------");

                        Console.WriteLine(" > " + menuopciones[i]);
                        Console.WriteLine(menuopciones[i + 1]);
                        Console.WriteLine(menuopciones[i + 2]);
                        Console.WriteLine(menuopciones[i + 3]);
                        Console.WriteLine(menuopciones[i + 4]);
                        Console.WriteLine(menuopciones[i + 5]);
                        i = i + 1;
                    }
                    else if (i == 1)
                    {
                        Console.WriteLine("Seleccione una opcion");
                        Console.WriteLine("-------------------------------------");

                        Console.WriteLine(menuopciones[i - 1]);
                        Console.WriteLine(" > " + menuopciones[i]);
                        Console.WriteLine(menuopciones[i + 1]);
                        Console.WriteLine(menuopciones[i + 2]);
                        Console.WriteLine(menuopciones[i + 3]);
                        Console.WriteLine(menuopciones[i + 4]);
                        i = i + 1;
                    }
                    else if (i == 2)
                    {
                        Console.WriteLine("Seleccione una opcion");
                        Console.WriteLine("-------------------------------------");

                        Console.WriteLine(menuopciones[i - 2]);
                        Console.WriteLine(menuopciones[i - 1]);
                        Console.WriteLine(" > " + menuopciones[i]);
                        Console.WriteLine(menuopciones[i + 1]);
                        Console.WriteLine(menuopciones[i + 2]);
                        Console.WriteLine(menuopciones[i + 3]);
                        i = i + 1;
                    }
                    else if (i == 3)
                    {
                        Console.WriteLine("Seleccione una opcion");
                        Console.WriteLine("-------------------------------------");

                        Console.WriteLine(menuopciones[i - 3]);
                        Console.WriteLine(menuopciones[i - 2]);
                        Console.WriteLine(menuopciones[i - 1]);
                        Console.WriteLine(" > " + menuopciones[i]);
                        Console.WriteLine(menuopciones[i + 1]);
                        Console.WriteLine(menuopciones[i + 2]);
                        i = i + 1;

                    }
                    else if (i == 4)
                    {
                        Console.WriteLine("Seleccione una opcion");
                        Console.WriteLine("-------------------------------------");

                        Console.WriteLine(menuopciones[i - 4]);
                        Console.WriteLine(menuopciones[i - 3]);
                        Console.WriteLine(menuopciones[i - 2]);
                        Console.WriteLine(menuopciones[i - 1]);
                        Console.WriteLine(" > " + menuopciones[i]);
                        Console.WriteLine(menuopciones[i + 1]);

                        i = i + 1;
                    }
                    else if (i == 5)
                    {
                        Console.WriteLine("Seleccione una opcion");
                        Console.WriteLine("-------------------------------------");

                        Console.WriteLine(menuopciones[i - 5]);
                        Console.WriteLine(menuopciones[i - 4]);
                        Console.WriteLine(menuopciones[i - 3]);
                        Console.WriteLine(menuopciones[i - 2]);
                        Console.WriteLine(menuopciones[i - 1]);
                        Console.WriteLine(" > " + menuopciones[i]);

                        i = i;
                    }
                }

                if (tecla.Key == ConsoleKey.UpArrow)
                {


                    if (i == 0)
                    {
                        Console.WriteLine("Seleccione una opcion");
                        Console.WriteLine("-------------------------------------");

                        Console.WriteLine(" > " + menuopciones[i]);
                        Console.WriteLine(menuopciones[i + 1]);
                        Console.WriteLine(menuopciones[i + 2]);
                        Console.WriteLine(menuopciones[i + 3]);
                        Console.WriteLine(menuopciones[i + 4]);
                        Console.WriteLine(menuopciones[i + 5]);
                        i = i;
                    }
                    else if (i == 1)
                    {
                        Console.WriteLine("Seleccione una opcion");
                        Console.WriteLine("-------------------------------------");

                        Console.WriteLine(menuopciones[i - 1]);
                        Console.WriteLine(" > " + menuopciones[i]);
                        Console.WriteLine(menuopciones[i + 1]);
                        Console.WriteLine(menuopciones[i + 2]);
                        Console.WriteLine(menuopciones[i + 3]);
                        Console.WriteLine(menuopciones[i + 4]);
                        i = i - 1;
                    }
                    else if (i == 2)
                    {
                        Console.WriteLine("Seleccione una opcion");
                        Console.WriteLine("-------------------------------------");

                        Console.WriteLine(menuopciones[i - 2]);
                        Console.WriteLine(menuopciones[i - 1]);
                        Console.WriteLine(" > " + menuopciones[i]);
                        Console.WriteLine(menuopciones[i + 1]);
                        Console.WriteLine(menuopciones[i + 2]);
                        Console.WriteLine(menuopciones[i + 3]);
                        i = i - 1;
                    }
                    else if (i == 3)
                    {
                        Console.WriteLine("Seleccione una opcion");
                        Console.WriteLine("-------------------------------------");

                        Console.WriteLine(menuopciones[i - 3]);
                        Console.WriteLine(menuopciones[i - 2]);
                        Console.WriteLine(menuopciones[i - 1]);
                        Console.WriteLine(" > " + menuopciones[i]);
                        Console.WriteLine(menuopciones[i + 1]);
                        Console.WriteLine(menuopciones[i + 2]);
                        i = i - 1;
                    }
                    else if (i == 4)
                    {

                        Console.WriteLine("Seleccione una opcion");
                        Console.WriteLine("-------------------------------------");

                        Console.WriteLine(menuopciones[i - 4]);
                        Console.WriteLine(menuopciones[i - 3]);
                        Console.WriteLine(menuopciones[i - 2]);
                        Console.WriteLine(menuopciones[i - 1]);
                        Console.WriteLine(" > " + menuopciones[i]);
                        Console.WriteLine(menuopciones[i + 1]);
                        i = i - 1;

                    }
                    else if (i == 5)
                    {
                        Console.WriteLine("Seleccione una opcion");
                        Console.WriteLine("-------------------------------------");

                        Console.WriteLine(menuopciones[i - 5]);
                        Console.WriteLine(menuopciones[i - 4]);
                        Console.WriteLine(menuopciones[i - 3]);
                        Console.WriteLine(menuopciones[i - 2]);
                        Console.WriteLine(menuopciones[i - 1]);
                        Console.WriteLine(" > " + menuopciones[i]);

                        i = i - 1;
                    }
                }
                if (tecla.Key == ConsoleKey.Enter)
                    {
                    if (i == 0)
                    {
                        Console.WriteLine("Seleccione una opcion");
                        Console.WriteLine(" > " + submenu[j + 1]);
                    }
                    else if (i == 1)
                    {
                        Console.WriteLine("Seleccione una opcion");
                        Console.WriteLine(" > " + submenu[j + 1]);
                    }
                    else if (i == 2)
                    {
                        Console.WriteLine("Seleccione una opcion");
                        Console.WriteLine(" > " + submenu[j]);
                        Console.WriteLine(submenu[j + 1]);
                        Console.WriteLine(submenu[j + 2]);
                        Console.WriteLine(submenu[j + 3]);

                    }
                    else if (i == 3)
                    {
                        Console.WriteLine("Seleccione una opcion");
                        Console.WriteLine(" > " + submenu[j]);
                        Console.WriteLine(submenu[j + 1]);
                        Console.WriteLine(submenu[j + 2]);
                        Console.WriteLine(submenu[j + 3]);

                    }
                    else if (i == 4)
                    {
                        Console.WriteLine("Seleccione una opcion");
                        Console.WriteLine(" > " + submenu[j]);
                        Console.WriteLine(submenu[j + 1]);
                        Console.WriteLine(submenu[j + 2]);
                        Console.WriteLine(submenu[j + 3]);

                    }
                    else if (i == 5)
                    {
                        Console.WriteLine("Seleccione una opcion");
                        Console.WriteLine(" > " + submenu[j]);
                        Console.WriteLine(submenu[j + 1]);
                        Console.WriteLine(submenu[j + 2]);
                        Console.WriteLine(submenu[j + 3]);

                    }
                    else if (i == 6)
                    {
                        
                    }
                }
                tecla = Console.ReadKey();
                Console.Clear();
            }
            Console.ReadLine();
        }
        */
    }
}
