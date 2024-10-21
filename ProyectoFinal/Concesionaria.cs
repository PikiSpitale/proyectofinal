using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    internal class Concesionaria
    {
        //Prop Privadas
        private List<Marca> listMarcas;
        private List<Segmento> listSegmentos;
        private List<Combustible> listCombustibles;
        private List<Auto> listAutos;
        private List<Moto> listMotos;
        private List<Camion> listCamiones;

        //Constructor
        public Concesionaria() 
        {
            listMarcas = new List<Marca>();
            listSegmentos = new List<Segmento>();
            listCombustibles = new List<Combustible>();
            listAutos = new List<Auto>();
            listMotos = new List<Moto>();
            listCamiones = new List<Camion>();   
        }
        //Metodos

        public static bool Booleano(string dato)
        {
            if (dato == "si")
            {
                return true;
            }
            else return false;
        }

        public static string Cadena(bool dato)
        {
            if (dato)
            {
                return "si";
            }else return "no";
        }

        //--------------------------------------------------------------------------
        //----------------------------------LISTAS----------------------------------
        public void CargarListas(string txt)
        {
            FileStream Archivo = new FileStream(txt, FileMode.Open, FileAccess.Read);
            StreamReader leer = new StreamReader(Archivo);

            if (File.Exists(txt))
            {
                while (leer.EndOfStream == false)
                {
                    try
                    {
                        string linea = leer.ReadLine();
                        List<string> datos = new List<string>(linea.Split(';'));

                        switch (txt)
                        {
                            case "marcas.txt":
                                Marca marca = new Marca(int.Parse(datos[0]), datos[1]);
                                listMarcas.Add(marca);
                                break;
                            case "segmentos.txt":
                                Segmento segmento = new Segmento(int.Parse(datos[0]), datos[1]);
                                listSegmentos.Add(segmento);
                                break;
                            case "combustibles.txt":
                                Combustible combustible = new Combustible(int.Parse(datos[0]), datos[1]);
                                listCombustibles.Add(combustible);
                                break;
                            case "autos.txt":

                                Auto auto = new Auto(int.Parse(datos[0]), int.Parse(datos[1]), int.Parse(datos[2]), int.Parse(datos[3]),
                                                            datos[4], int.Parse(datos[5]), int.Parse(datos[6]), datos[7], int.Parse(datos[8]),
                                                            datos[9], datos[10], int.Parse(datos[11]), Booleano(datos[12]));
                                listAutos.Add(auto);
                                break;

                            case "motos.txt":

                                Moto moto = new Moto(int.Parse(datos[0]), int.Parse(datos[1]), int.Parse(datos[2]), int.Parse(datos[3]),
                                                            datos[4], int.Parse(datos[5]), int.Parse(datos[6]), datos[7], int.Parse(datos[8]),
                                                            datos[9], datos[10], int.Parse(datos[11]), Booleano(datos[12]));
                                listMotos.Add(moto);
                                break;

                            case "camiones.txt":

                                Camion camion = new Camion(int.Parse(datos[0]), int.Parse(datos[1]), int.Parse(datos[2]), int.Parse(datos[3]),
                                                            datos[4], int.Parse(datos[5]), int.Parse(datos[6]), datos[7], int.Parse(datos[8]),
                                                            datos[9], datos[10], int.Parse(datos[11]), Booleano(datos[12]), int.Parse(datos[13]), int.Parse(datos[14]));
                                listCamiones.Add(camion);
                                break;

                            default: break;
                        }

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.ToString());
                    }
                }
            }
            Archivo.Close();
            leer.Close();
        }
        public void ActualizarListas(string txt) 
        {
            FileStream Archivo = new FileStream(txt, FileMode.Create, FileAccess.Write);
            StreamWriter escribir = new StreamWriter(Archivo);
            switch (txt)
            {
                case "marcas.txt":
                    {
                        foreach (Marca marca in listMarcas)
                        {
                            escribir.WriteLine(marca.idMarca.ToString() + ";" + marca.nombMarca);
                        }
                        break;
                    }
                case "segmentos.txt":
                    {
                        foreach (Segmento seg in listSegmentos)
                        {
                            escribir.WriteLine(seg.idMarca.ToString() + ";" + seg.nombSegmento);
                        }
                        break;
                    }
                case "combustibles.txt":
                    {
                        foreach (Combustible comb in listCombustibles)
                        {
                            escribir.WriteLine(comb.idCombustible.ToString() + ";" + comb.nombCombustible);
                        }
                        break;
                    }
                case "autos.txt":
                    {
                        foreach (Auto auto in listAutos)
                        {
                            escribir.WriteLine(auto.idVehiculo.ToString() + ";" + auto.idMarca.ToString() + ";" + auto.idSegmento.ToString() + ";" + 
                                                auto.idCombustible.ToString() + ";" + auto.patente + ";" + auto.kilometros.ToString() + ";" + auto.anio.ToString() + ";" + 
                                                auto.modelo + ";" + auto.precioVta.ToString() + ";" + auto.observaciones + ";" + auto.color + ";" + auto.cilindrada + ";" + 
                                                Cadena(auto.cajaCarga));
                        }
                        break;
                    }
                case "motos.txt":
                    {
                        foreach (Moto moto in listMotos)
                        {
                            escribir.WriteLine(moto.idVehiculo.ToString() + ";" + moto.idMarca.ToString() + ";" + moto.idSegmento.ToString() + ";" +
                                                moto.idCombustible.ToString() + ";" + moto.patente + ";" + moto.kilometros.ToString() + ";" + moto.anio.ToString() + ";" +
                                                moto.modelo + ";" + moto.precioVta.ToString() + ";" + moto.observaciones + ";" + moto.color + ";" + moto.cilindrada + ";" +
                                                Cadena(moto.cajaCarga));
                        }
                        break;
                    }
                case "camiones.txt":
                    { 
                        foreach (Camion camion in listCamiones)
                        {
                            escribir.WriteLine(camion.idVehiculo.ToString() + ";" + camion.idMarca.ToString() + ";" + camion.idSegmento.ToString() + ";" +
                                                camion.idCombustible.ToString() + ";" + camion.patente + ";" + camion.kilometros.ToString() + ";" + camion.anio.ToString() + ";" +
                                                camion.modelo + ";" + camion.precioVta.ToString() + ";" + camion.observaciones + ";" + camion.color + ";" + camion.cilindrada + ";" +
                                                Cadena(camion.cajaCarga) + ";" + camion.dimensionCaja.ToString() + ";" + camion.cargaMax.ToString());
                        }
                        break;
                    }
                default: break;
            }
            
            escribir.Close();
            Archivo.Close();
        }
        //--------------------------------------------------------------------------
        //----------------------------------MARCA-----------------------------------
        //MOSTRAR
        public void MostrarMarcas()
        {
            foreach (Marca marca in listMarcas)
            {
                marca.MostrarMarSegComb();
            }

        }
        public void EditarMarca()
        {
            MostrarMarcas();          
            Console.WriteLine("---------------------------");
            Console.Write("Ingrese id que desea editar: ");
            int id = int.Parse(Console.ReadLine());
            Console.Clear();
            foreach(Marca marca in listMarcas)
            {
                if (marca.idMarca == id)
                {
                    marca.Editar();
                }
            }
            ActualizarListas("marcas.txt");
        }
        public void CargarMarca()
        {
            Console.Write("Ingrese nombre de la marca: ");
            string nomb = Console.ReadLine();

            Marca marca = new Marca(listMarcas.Count, nomb);
            listMarcas.Add(marca);

            ActualizarListas("marcas.txt");
        }
        public void BorrarMarca()
        {
            Console.Write("Ingrese id que desea eliminar o ingrese -1 si desea salir: ");
            int id = int.Parse(Console.ReadLine());
            int cont = 0;
            if (id != -1)
            {
                foreach (Marca marca in listMarcas.ToList<Marca>())
                {
                    if (marca.idMarca == id)
                    {
                        listMarcas.RemoveAt(cont);
                    }
                    cont++;
                }
            }
            ActualizarListas("marcas.txt");
        }

        //------------------------------SEGMENTOS-----------------------------------
        public void MostrarSegmentos()
        {
            foreach (Segmento seg in listSegmentos)
            {
                seg.MostrarMarSegComb();
            }
        }
        public void EditarSegmento()
        {
            MostrarSegmentos();
            Console.WriteLine("---------------------------");
            Console.Write("Ingrese id que desea editar: ");
            int id = int.Parse(Console.ReadLine());
            Console.Clear();
            foreach (Segmento seg in listSegmentos)
            {
                if (seg.idSegmento == id)
                {
                    seg.Editar();
                }
            }
            ActualizarListas("segmentos.txt");
        }
        public void CargarSegmento()
        {
            Console.Write("Ingrese nombre de la Segmento: ");
            string nomb = Console.ReadLine();

            Segmento seg = new Segmento(listSegmentos.Count, nomb);
            listSegmentos.Add(seg);

            ActualizarListas("segmentos.txt");
        }
        public void BorrarSegmento()
        {
            Console.Write("Ingrese id que desea eliminar o ingrese -1 si desea salir: ");
            int id = int.Parse(Console.ReadLine());
            int cont = 0;
            if (id != -1)
            {
                foreach (Segmento seg in listSegmentos.ToList<Segmento>())
                {
                    if (seg.idSegmento == id)
                    {
                        listSegmentos.RemoveAt(cont);
                    }
                    cont++;
                }
            }
            ActualizarListas("segmentos.txt");
        }
        //------------------------------COMBUSTIBLES-----------------------------------
        public void MostrarCombustibles()
        {
            foreach (Combustible comb in listCombustibles)
            {
                comb.MostrarMarSegComb();
            }
        }
        public void EditarCombustible()
        {
            MostrarCombustibles();
            Console.WriteLine("---------------------------");
            Console.Write("Ingrese id que desea editar: ");
            int id = int.Parse(Console.ReadLine());
            Console.Clear();
            foreach (Combustible comb in listCombustibles)
            {
                if (comb.idCombustible == id)
                {
                    comb.Editar();
                }
            }
            ActualizarListas("combustibles.txt");
        }
        public void CargarCombustible()
        {
            Console.Write("Ingrese nombre de la combustible: ");
            string nomb = Console.ReadLine();

            Combustible comb = new Combustible(listCombustibles.Count, nomb);
            listCombustibles.Add(comb);

            ActualizarListas("combustibles.txt");
        }
        public void BorrarCombustible()
        {
            Console.Write("Ingrese id que desea eliminar o ingrese -1 si desea salir: ");
            int id = int.Parse(Console.ReadLine());
            int cont = 0;
            if (id != -1)
            {
                foreach (Combustible comb in listCombustibles.ToList<Combustible>())
                {
                    if (comb.idCombustible == id)
                    {
                        listCombustibles.RemoveAt(cont);
                    }
                    cont++;
                }
            }
            ActualizarListas("combustibles.txt");
        }
        //------------------------------AUTOS-----------------------------------
        public void MostrarAutos()
        {
            foreach (Auto auto in listAutos)
            {
                string marca = listMarcas[auto.idMarca].MostrarId();
                string segmento = listSegmentos[auto.idSegmento].MostrarId();
                string combustible = listCombustibles[auto.idCombustible].MostrarId();
                string caja = Cadena(auto.cajaCarga);

                auto.MostrarVehiculo(marca, segmento, combustible, caja);
            }
        }       
        public void EditarAuto() 
        {
            MostrarAutos();
            Console.WriteLine("---------------------------");
            Console.Write("Ingrese id que desea editar: ");
            int id = int.Parse(Console.ReadLine());
            Console.Clear();
            foreach (Auto auto in listAutos)
            {
                if (auto.idVehiculo == id)
                {
                    auto.Editar();
                }
            }
            ActualizarListas("autos.txt");
        }
        public void CargarAuto()
        {
            Console.Write("Ingrese id de la marca: ");
            int idmarca = int.Parse(Console.ReadLine());

            Console.Write("Ingrese id del segmento: ");
            int idseg = int.Parse(Console.ReadLine());

            Console.Write("Ingrese id del combustible: ");
            int idcomb = int.Parse(Console.ReadLine());

            Console.Write("Ingrese patente: ");
            string patente = Console.ReadLine();

            Console.Write("Ingrese kilometros: ");
            int kilometros = int.Parse(Console.ReadLine());

            Console.Write("Ingrese año: ");
            int anio = int.Parse(Console.ReadLine());

            Console.Write("Ingrese modelo: ");
            string modelo = Console.ReadLine();

            Console.Write("Ingrese precio: ");
            float precio = float.Parse(Console.ReadLine());

            Console.Write("Ingrese observaciones: ");
            string observaciones = Console.ReadLine();

            Console.Write("Ingrese color: ");
            string color = Console.ReadLine();

            Console.Write("Ingrese cilindrada: ");
            int cilindrada = int.Parse(Console.ReadLine());

            Console.Write("Ingrese caja de carga: ");
            string cajacarga = Console.ReadLine();

            Auto auto = new Auto(listAutos.Count, idmarca, idseg, idcomb, patente, kilometros, anio, modelo, precio, observaciones, color, cilindrada, Booleano(cajacarga));
            listAutos.Add(auto);

            ActualizarListas("autos.txt");
        }
        public void BorrarAuto()
        {
            Console.Write("Ingrese id que desea eliminar o ingrese -1 si desea salir: ");
            int id = int.Parse(Console.ReadLine());
            int cont = 0;
            if (id != -1)
            {
                foreach (Auto auto in listAutos.ToList<Auto>())
                {
                    if (auto.idVehiculo == id)
                    {
                        listAutos.RemoveAt(cont);
                    }
                    cont++;
                }
            }
            ActualizarListas("autos.txt");
        }
        //------------------------------CAMIONES-----------------------------------
        public void MostrarCamiones()
        {
            foreach (Camion camion in listCamiones)
            {
                string marca = listMarcas[camion.idMarca].MostrarId();
                string segmento = listSegmentos[camion.idSegmento].MostrarId();
                string combustible = listCombustibles[camion.idCombustible].MostrarId();
                string caja = Cadena(camion.cajaCarga);

                camion.MostrarVehiculo(marca, segmento, combustible, caja);
            }
        }
        public void EditarCamion()
        {
            MostrarCamiones();
            Console.WriteLine("---------------------------");
            Console.Write("Ingrese id que desea editar: ");
            int id = int.Parse(Console.ReadLine());
            Console.Clear();
            foreach (Camion camion in listCamiones)
            {
                if (camion.idVehiculo == id)
                {
                    camion.Editar();
                }
            }
            ActualizarListas("camiones.txt");
        }
        public void CargarCamion()
        {
            Console.Write("Ingrese id de la marca: ");
            int idmarca = int.Parse(Console.ReadLine());

            Console.Write("Ingrese id del segmento: ");
            int idseg = int.Parse(Console.ReadLine());

            Console.Write("Ingrese id del combustible: ");
            int idcomb = int.Parse(Console.ReadLine());

            Console.Write("Ingrese patente: ");
            string patente = Console.ReadLine();

            Console.Write("Ingrese kilometros: ");
            int kilometros = int.Parse(Console.ReadLine());

            Console.Write("Ingrese año: ");
            int anio = int.Parse(Console.ReadLine());

            Console.Write("Ingrese modelo: ");
            string modelo = Console.ReadLine();

            Console.Write("Ingrese precio: ");
            float precio = float.Parse(Console.ReadLine());

            Console.Write("Ingrese observaciones: ");
            string observaciones = Console.ReadLine();

            Console.Write("Ingrese color: ");
            string color = Console.ReadLine();

            Console.Write("Ingrese cilindrada: ");
            int cilindrada = int.Parse(Console.ReadLine());

            Console.Write("Ingrese caja de carga: ");
            string cajacarga = Console.ReadLine();

            Console.Write("Ingrese dimension de la caja de carga: ");
            int dimensioncajacarga = int.Parse(Console.ReadLine());

            Console.Write("Ingrese carga maxima: ");
            int cargamaxima = int.Parse(Console.ReadLine());

            Camion camion = new Camion(listCamiones.Count, idmarca, idseg, idcomb, patente, kilometros, anio, modelo, precio, observaciones, color, cilindrada, Booleano(cajacarga), dimensioncajacarga, cargamaxima);
            listCamiones.Add(camion);

            ActualizarListas("camiones.txt");
        }
        public void BorrarCamion()
        {
            Console.Write("Ingrese id que desea eliminar o ingrese -1 si desea salir: ");
            int id = int.Parse(Console.ReadLine());
            int cont = 0;
            if (id != -1)
            {
                foreach (Camion cam in listCamiones.ToList<Camion>())
                {
                    if (cam.idVehiculo == id)
                    {
                        listCamiones.RemoveAt(cont);
                    }
                    cont++;
                }
            }
            ActualizarListas("camiones.txt");
        }
        //------------------------------MOTOS-----------------------------------
        public void MostrarMotos()
        {
            foreach (Moto moto in listMotos)
            {
                string marca = listMarcas[moto.idMarca].MostrarId();
                string segmento = listSegmentos[moto.idSegmento].MostrarId();
                string combustible = listCombustibles[moto.idCombustible].MostrarId();
                string caja = Cadena(moto.cajaCarga);

                moto.MostrarVehiculo(marca, segmento, combustible, caja);
            }
        }
        public void EditarMoto()
        {
            MostrarMotos();
            Console.WriteLine("---------------------------");
            Console.Write("Ingrese id que desea editar: ");
            int id = int.Parse(Console.ReadLine());
            Console.Clear();
            foreach (Moto moto in listMotos)
            {
                if (moto.idVehiculo == id)
                {
                    moto.Editar();
                }
            }
            ActualizarListas("motos.txt");
        }
        public void CargarMoto()
        {
            Console.Write("Ingrese id de la marca: ");
            int idmarca = int.Parse(Console.ReadLine());

            Console.Write("Ingrese id del segmento: ");
            int idseg = int.Parse(Console.ReadLine());

            Console.Write("Ingrese id del combustible: ");
            int idcomb = int.Parse(Console.ReadLine());

            Console.Write("Ingrese patente: ");
            string patente = Console.ReadLine();

            Console.Write("Ingrese kilometros: ");
            int kilometros = int.Parse(Console.ReadLine());

            Console.Write("Ingrese año: ");
            int anio = int.Parse(Console.ReadLine());

            Console.Write("Ingrese modelo: ");
            string modelo = Console.ReadLine();

            Console.Write("Ingrese precio: ");
            float precio = float.Parse(Console.ReadLine());

            Console.Write("Ingrese observaciones: ");
            string observaciones = Console.ReadLine();

            Console.Write("Ingrese color: ");
            string color = Console.ReadLine();

            Console.Write("Ingrese cilindrada: ");
            int cilindrada = int.Parse(Console.ReadLine());

            Console.Write("Ingrese caja de carga: ");
            string cajacarga = Console.ReadLine();

            Moto moto = new Moto(listMotos.Count, idmarca, idseg, idcomb, patente, kilometros, anio, modelo, precio, observaciones, color, cilindrada, Booleano(cajacarga));
            listMotos.Add(moto);

            ActualizarListas("motos.txt");
        }
        public void BorrarMoto()
        {
            Console.Write("Ingrese id que desea eliminar o ingrese -1 si desea salir: ");
            int id = int.Parse(Console.ReadLine());
            int cont = 0;
            if (id != -1)
            {
                foreach (Moto moto in listMotos.ToList<Moto>())
                {
                    if (moto.idVehiculo == id)
                    {
                        listMotos.RemoveAt(cont);
                    }
                    cont++;
                }
            }
            ActualizarListas("motos.txt");
        }
        //Prop publicas
    }
}
