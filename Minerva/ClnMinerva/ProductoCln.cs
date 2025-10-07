using CadMinerva;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnMinerva
{
    public class ProductoCln
    {
        public static int insertar(Producto producto)
        {
            using (var context = new MinervaEntities())
            {
                context.Producto.Add(producto);
                context.SaveChanges();
                return producto.id;
            }
        }

        public static int actualizar(Producto producto)
        {
            using (var context = new MinervaEntities())
            {
                var existe = context.Producto.Find(producto.id);
                existe.idUnidadMedida = producto.idUnidadMedida;
                existe.codigo = producto.codigo;
                existe.descripcion = producto.descripcion;
                existe.saldo = producto.saldo;
                existe.precioVenta = producto.precioVenta;
                existe.usuarioRegistro = producto.usuarioRegistro;
                return context.SaveChanges();
            }
        }

        public static int eliminar(int id, string usuarioRegistro)
        {
            using (var context = new MinervaEntities())
            {
                var existe = context.Producto.Find(id);
                existe.estado = -1;
                existe.usuarioRegistro = usuarioRegistro;
                return context.SaveChanges();
            }
        }

        public static Producto obtenerUno(int id)
        {
            using (var context = new MinervaEntities())
            {
                return context.Producto.Find(id);
            }
        }

        public static List<Producto> listar()
        {
            using (var context = new MinervaEntities())
            {
                return context.Producto.Where(x => x.estado != -1).ToList();
            }
        }

        public static List<paProductoListar_Result> listarPa(string parametro)
        {
            using (var context = new MinervaEntities())
            {
                return context.paProductoListar(parametro).ToList();
            }
        }
    }
}
