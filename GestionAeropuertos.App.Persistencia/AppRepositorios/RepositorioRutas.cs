using System.Collections.Generic;
using GestionAeropuertos.App.Dominio;
using System.Linq;
using System;

namespace GestionAeropuertos.App.Persistencia.AppRepositorios
{
    public class RepositorioRutas
    {
        List<Ruta> rutas;
        private readonly AppContext _appContext = new AppContext();   

   

        public IEnumerable<Ruta> GetAll()
        {
            return _appContext.rutas;
        }

        public Ruta GetRutaWithId(int id){
            return _appContext.rutas.Find(id);
        }

        public Ruta Create(Ruta newRuta)
        {
            var addRuta = _appContext.rutas.Add(newRuta);
            _appContext.SaveChanges();
            return addRuta.Entity;

        }


       public Ruta Update(Ruta newRuta){
            var ruta = _appContext.rutas.Find(newRuta.id);
            if(ruta != null){
                ruta.origen = newRuta.origen;
                ruta.destino = newRuta.destino;
                ruta.tiempo_estimado = newRuta.tiempo_estimado;
               
                //Guardar en base de datos
                 _appContext.SaveChanges();
            }
        return ruta;
        }

        

        public void Delete(int id)
        {
        var ruta = _appContext.rutas.Find(id);
        if (ruta == null)
            return;
        _appContext.rutas.Remove(ruta);
        _appContext.SaveChanges();
        }

        

 
    }
}
