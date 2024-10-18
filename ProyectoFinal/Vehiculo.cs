using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    internal class Vehiculo
    {
        //Prop Privadas
        private int P_idVehiculo;
        private int P_idMarca;
        private int P_idSegmento;
        private int P_idCombustible;
        private string P_patente;
        private int P_kilometros;
        private int P_anio;
        private string P_modelo;
        private float P_precioVta;
        private string P_observaciones;
        private string P_color;
        private int P_cilindrada;
        private bool P_cajaCarga;
        private int P_dimensionCaja;
        private int P_cargaMax;


        //Constructores
        //-------VEHICULOS----------
        public Vehiculo(int Idvehiculo, int Idmarca, int Idsegmento, int Idcombustible,
                         string Patente, int Kilometros, int Anio, string Modelo, float Preciovta,
                         string Observaciones, string Color, int Cilindrada, bool CajaCarga)
        {
            this.idVehiculo = Idvehiculo;
            this.idMarca = Idmarca;
            this.idSegmento = Idsegmento;
            this.idCombustible = Idcombustible;
            this.patente = Patente;
            this.kilometros = Kilometros;
            this.anio = Anio;
            this.modelo = Modelo;
            this.precioVta = Preciovta;
            this.observaciones = Observaciones;
            this.color = Color;
            this.cilindrada = Cilindrada;
            this.cajaCarga = CajaCarga;
        }
        // ------- MARCA - SEGMENTO - COMBUSTIBLE --------
        public Vehiculo(int Id)
        {
            this.idMarca = Id;
            this.idSegmento = Id;
            this.idCombustible = Id;
        }



        //Metodos
        public virtual void MostrarVehiculo(string marca, string segmento, string combustible, string caja) { }
        public virtual string MostrarId() { return "-1"; }
        public virtual void MostrarMarSegComb() { }

        


        //Prop publicas
        public int idVehiculo { get { return this.P_idVehiculo; } set { this.P_idVehiculo = value; } }
        public int idMarca { get { return this.P_idMarca; } set { this.P_idMarca = value; } }
        public int idSegmento { get { return this.P_idSegmento; } set { this.P_idSegmento = value; } }
        public int idCombustible { get { return this.P_idCombustible; }set { this.P_idCombustible = value; } }
        public string patente { get { return this.P_patente;}set{this.P_patente = value; } }
        public int kilometros { get {  return this.P_kilometros; } set { this.P_kilometros = value; } }
        public int anio { get { return this.P_anio; } set { this.P_anio = value; } }
        public string modelo { get { return this.P_modelo; } set { this.P_modelo = value; } }
        public float precioVta { get { return this.P_precioVta;}set { this.P_precioVta = value; } }
        public string observaciones { get { return this.P_observaciones; } set { this.P_observaciones = value; } }
        public string color { get { return this.P_color; } set { P_color = value; } }
        public int cilindrada { get { return this.P_cilindrada; } set { this.P_cilindrada = value; } }
        public bool cajaCarga { get { return P_cajaCarga; } set { this.P_cajaCarga = value; } }
        public int dimensionCaja { get { return this.P_dimensionCaja; } set { this.P_dimensionCaja = value; } }
        public int cargaMax { get { return this.P_cargaMax; } set { this.P_cargaMax = value; } }
    }
}
