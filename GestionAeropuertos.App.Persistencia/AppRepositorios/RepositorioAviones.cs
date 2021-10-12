using System.Collections.Generic;
using GestionAeropuertos.App.Dominio;
using System.Linq;
using System;

namespace GestionAeropuertos.App.Persistencia.AppRepositorios
{
    public class RepositorioAviones
    {
        List<Avion> aviones;
        private readonly AppContext _appContext = new AppContext();   

   

        public IEnumerable<Avion> GetAll()
        {
            return _appContext.Aviones;
        }

        public Avion GetAvionWithId(int id){
            return _appContext.Aviones.Find(id);
        }

        public Avion Create(Avion newAvion)
        {
            var addAvion = _appContext.Aviones.Add(newAvion);
            _appContext.SaveChanges();
            return addAvion.Entity;

        }


       public Avion Update(Avion newAvion){
            var avion = _appContext.Aviones.Find(newAvion.id);
            if(avion != null){
                avion.marca = newAvion.marca;
                avion.modelo = newAvion.modelo;
                avion.numero_asientos = newAvion.numero_asientos;
                avion.numero_baños = newAvion.numero_baños;
                avion.capacidad_peso = newAvion.capacidad_peso;
                //Guardar en base de datos
                 _appContext.SaveChanges();
            }
        return avion;
        }

        

        public void Delete(int id)
        {
        var avion = _appContext.Aviones.Find(id);
        if (avion == null)
            return;
        _appContext.Aviones.Remove(avion);
        _appContext.SaveChanges();
        }

        

 
    }
}
