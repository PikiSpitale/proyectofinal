using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    internal class Venta : Vehiculo
    {
        //Prop Privadas
        private int p_id_cliente;
        private DateTime p_fecha_compra;
        private DateTime fecha_entrega;
        private double p_subtotal;
        private double p_iva;
        private double p_descuento;
        private double p_total;

        //Constructores
        public Venta(int Id_cliente, int Idvehiculo, DateTime Fecha_compra, DateTime Fecha_entrega, double Subtotal) : base (Idvehiculo)
        {
            this.Id_cliente = Id_cliente;
            this.Fecha_compra = Fecha_compra;
            this.Fecha_entrega = Fecha_entrega;
            this.Subtotal = Subtotal;
        }
        
        //Metodos
        public void MostrarVenta() { }
        
        

        //Prop publicas
        public int Id_cliente
        {
            get { return this.p_id_cliente; }
            set { this.p_id_cliente = value; }
        }
        public DateTime Fecha_compra
        {
            get { return this.p_fecha_compra; }
            set { this.p_fecha_compra = value;}
        }
        public DateTime Fecha_entrega
        {
            get { return this.fecha_entrega; }
            set { this.fecha_entrega = value;}
        }
        public double Subtotal
        {
            get { return this.Subtotal; }
            set { this.Subtotal = value; }
        }
        public double Iva
        {
            get { return this.Subtotal * 0.21; }
        }
        public double Descuento
        {
            get { return this.p_descuento; }
        }
        public double Total
        {
            get { return this.Subtotal + this.Iva + this.Descuento; }
        }
       
    }
}
