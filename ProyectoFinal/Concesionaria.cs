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

        public bool Booleano(string dato)
        {
            if (dato == "si")
            {
                return true;
            }
            else return false;
        }

        public string Cadena(bool dato)
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
                            case "vehiculos.txt":
                                {
                                    int seg = int.Parse(datos[2]);
                                    if((seg == 0) || (seg == 1) || (seg == 2) || (seg == 3))
                                    {
                                        Auto auto = new Auto(int.Parse(datos[0]), int.Parse(datos[1]), int.Parse(datos[2]), int.Parse(datos[3]),
                                                            datos[4], int.Parse(datos[5]), int.Parse(datos[6]), datos[7], int.Parse(datos[8]),
                                                            datos[9], datos[10], int.Parse(datos[11]), Booleano(datos[12]));
                                        listAutos.Add(auto);
                                    }else if ((seg == 4) || (seg == 5) || (seg == 6)) 
                                    {
                                        Moto moto = new Moto(int.Parse(datos[0]), int.Parse(datos[1]), int.Parse(datos[2]), int.Parse(datos[3]),
                                                            datos[4], int.Parse(datos[5]), int.Parse(datos[6]), datos[7], int.Parse(datos[8]),
                                                            datos[9], datos[10], int.Parse(datos[11]), Booleano(datos[12]));
                                        listMotos.Add(moto);
                                    }else if(seg == 7)
                                    {
                                        Camion camion = new Camion(int.Parse(datos[0]), int.Parse(datos[1]), int.Parse(datos[2]), int.Parse(datos[3]),
                                                            datos[4], int.Parse(datos[5]), int.Parse(datos[6]), datos[7], int.Parse(datos[8]),
                                                            datos[9], datos[10], int.Parse(datos[11]), Booleano(datos[12]), int.Parse(datos[13]), int.Parse(datos[14]));
                                        listCamiones.Add(camion);
                                    }
                                    break;
                                }

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
            if (txt == "marcas.txt")
            {
                foreach (Marca marca in listMarcas)
                {
                    escribir.WriteLine(marca.idMarca.ToString() + ";" + marca.marca);
                }
            }

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
        public void EditarMarca(int id)
        {
            foreach(Marca marca in listMarcas)
            {
                if (marca.idMarca == id)
                {
                    marca.EditarMarca();
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

        public void MostrarCombustibles()
        {
            foreach (Combustible comb in listCombustibles)
            {
                comb.MostrarMarSegComb();
            }
        }

        public void MostrarAutos()
        {
            foreach (Auto auto in listAutos)
            {
                string marca = listMarcas[auto.idMarca].MostrarId();
                string segmento = listMarcas[auto.idSegmento].MostrarId();
                string combustible = listMarcas[auto.idCombustible].MostrarId();
                string caja = Cadena(auto.cajaCarga);

                auto.MostrarVehiculo(marca, segmento, combustible, caja);
            }
        }
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
        public void MostrarMotos()
        {
            foreach (Moto moto in listMotos)
            {
                string marca = listMarcas[moto.idMarca].MostrarId();
                string segmento = listMarcas[moto.idSegmento].MostrarId();
                string combustible = listMarcas[moto.idCombustible].MostrarId();
                string caja = Cadena(moto.cajaCarga);

                moto.MostrarVehiculo(marca, segmento, combustible, caja);
            }
        }
        //Prop publicas
    }
}
