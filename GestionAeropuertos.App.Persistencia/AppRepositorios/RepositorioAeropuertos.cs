using System.Collections.Generic;
using GestionAeropuertos.App.Dominio;
using System.Linq;
using System;

namespace GestionAeropuertos.App.Persistencia.AppRepositorios
{
    public class RepositorioAeropuertos
    {
        List<Aeropuerto> aeropuertos;
        private readonly AppContext _appContext = new AppContext();   

   

        public IEnumerable<Aeropuerto> GetAll()
        {
            return _appContext.aeropuertos;
        }

        public Aeropuerto GetAeropuertoWithId(int id){
            return _appContext.aeropuertos.Find(id);
        }

        public Aeropuerto Create(Aeropuerto newAeropuerto)
        {
            var addAeropuerto = _appContext.aeropuertos.Add(newAeropuerto);
            _appContext.SaveChanges();
            return addAeropuerto.Entity;

        }


       public Aeropuerto Update(Aeropuerto newAeropuerto){
            var aeropuerto = _appContext.aeropuertos.Find(newAeropuerto.id);
            if(aeropuerto != null){
                aeropuerto.nombre = newAeropuerto.nombre;
                aeropuerto.ciudad = newAeropuerto.ciudad;
                aeropuerto.pais = newAeropuerto.pais;
                aeropuerto.coordenada_x = newAeropuerto.coordenada_x;
                aeropuerto.coordenada_y = newAeropuerto.coordenada_y;
                //Guardar en base de datos
                 _appContext.SaveChanges();
            }
        return aeropuerto;
        }

        

        public void Delete(int id)
        {
        var aeropuerto = _appContext.aeropuertos.Find(id);
        if (aeropuerto == null)
            return;
        _appContext.aeropuertos.Remove(aeropuerto);
        _appContext.SaveChanges();
        }

        

 
    }
}
