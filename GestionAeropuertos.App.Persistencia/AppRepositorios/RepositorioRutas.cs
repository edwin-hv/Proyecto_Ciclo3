using System.Collections.Generic;
using GestionAeropuertos.App.Dominio;
using System.Linq;
using System;

namespace GestionAeropuertos.App.Persistencia.AppRepositorios
{
    public class RepositorioRutas
    {
        List<Ruta> rutas;

    public RepositorioRutas()
        {
            rutas= new List<Ruta>()
            {
                new Ruta{id=1,origen="A",destino= "B",tiempo_estimado= 3,},
                new Ruta{id=2,origen="C",destino= "D",tiempo_estimado= 5},
                new Ruta{id=3,origen="E",destino= "F",tiempo_estimado= 10}

            };
        }

        public IEnumerable<Ruta> GetAll()
        {
            return rutas;
        }

        public Ruta GetRutaWithId(int id){
            return rutas.SingleOrDefault(b => b.id == id);
        }

        public Ruta Create(Ruta newRuta)
        {
           newRuta.id=rutas.Max(r => r.id) +1; 
           rutas.Add(newRuta);
           return newRuta;
        }


       public Ruta Update(Ruta newRuta){
            var ruta= rutas.SingleOrDefault(b => b.id == newRuta.id);
            if(ruta != null){
                ruta.origen = newRuta.origen;
                ruta.destino = newRuta.destino;
                ruta.tiempo_estimado = newRuta.tiempo_estimado;
                
            }
        return ruta;
        }
 
    }
}
