using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    internal class Venta : Vehiculo
    {
        //Prop Privadas
        private int id_cliente;
        private DateTime fecha_compra;
        private DateTime fecha_entrega;
        private float subtotal;
        private float iva;
        private float descuento;
        private float total;

        //Constructores
        public Venta (int Id_cliente, DateTime Fecha_compra, DateTime Fecha_entrega, float Subtotal, float Iva, float Descuento, float Total)
        {
            this.id_cliente = Id_cliente;
            this.subtotal = Subtotal;
            this.iva = Iva;
            this.descuento = Descuento;
            this.total = Total;
        }


        //Metodos



        //Prop publicas
        public int Id_cliente
        {
            get { return this.id_cliente; }
            set { this.id_cliente = value; }
        }
        public DateTime Fecha_compra
        {
            get => this.fecha_compra;
        }
        public DateTime Fecha_entrega
        {
            get => this.fecha_entrega;
        }
        public float Subtotal
        {
            get { return this.Subtotal; }
            set { this.Subtotal = value; }
        }
        public float Iva
        {
            get { return this.iva; }
            set { this.iva = value; }
        }
        public float Descuento
        {
            get { return this.descuento; }
            set { this.descuento = value; }
        }
        public float Total
        {
            get { return this.total; }
            set { this.total = value; }
        }
       


    }
}
