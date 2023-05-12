using Lab3.Model;
using Microsoft.VisualBasic;
using System.Reflection.Metadata.Ecma335;

namespace Lab3.BL
{
    public class Metodos

       
    {
        public PrendaModelo prendaModelo;
        public PrendaModelo prendaModeloProvicional;
        public List<PrendaModelo> prendas;
        public int idx;
       
        public Metodos()
        {
             prendaModelo= new PrendaModelo();
            prendas= new List<PrendaModelo>();
        
            
        }


        public void SeRegistraPrenda(int id, string nombre, string talla, string marca, string desc)
        {
            prendaModelo = new PrendaModelo();
            prendaModelo.Id = id;
            prendaModelo.Nombre = nombre;
            prendaModelo.Marca = marca;
            prendaModelo.Talla = talla;
            prendaModelo.Descripcion = desc;
            prendas.Add(prendaModelo);
             
        }
        public List<PrendaModelo> SeMuestraListado()
        {

            return prendas;
        }
        public List<PrendaModelo> SeMuestranDetalles(int id)
        {
            List < PrendaModelo > nuevaLista= new List<PrendaModelo>();
            nuevaLista.Add(prendas[id-1]);
           


            return nuevaLista;
                
        }
       
       
    }
}