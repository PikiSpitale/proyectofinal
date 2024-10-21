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
        //Prop publicas
    }
}
