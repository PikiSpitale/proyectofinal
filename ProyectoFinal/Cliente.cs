using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    internal class Cliente
    {
        //Prop Privadas
        private int id_cliente;
        private string cliente;
        private int cuil;
        private string domicilio;
        private int id_localidad;
        private int telefono;
        private string correo;
        
        //Constructores

        public Cliente (int Id_cliente, string Clientes, int Cuil, string Domicilio, int Id_localidad, int Telefono, string Correo)
        {
            this.id_cliente = Id_cliente;
            this.cliente = Clientes;
            this.cuil = Cuil;
            this.domicilio = Domicilio;
            this.Id_localidad = Id_localidad;
            this.telefono = Telefono;
            this.correo = Correo;

        }

        //Metodos



        //Prop publicas
        public int Id_cliente
        {
            get { return this.id_cliente; }
            set { this.id_cliente = value; }
        }
        public string Clientes
        {
            get { return this.cliente; }
            set { this.cliente = value; }
        }
        public int Cuil
        {
            get { return this.cuil; }
            set { this.cuil = value; }
        }
        public string Domicilio
        {
            get { return this.domicilio; }
            set { this.domicilio = value; }
        }
        public int Id_localidad
        {
            get { return this.id_localidad; }
            set { this.id_localidad = value; }
        }
        public int Telefono
        {
            get { return this.telefono; }
            set {this.telefono = value; }
        }
        public string Correo
        {
            get { return this.correo; }
            set {this.correo = value;}
        }

    }
}
