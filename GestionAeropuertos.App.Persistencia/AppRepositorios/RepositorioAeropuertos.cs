using System.Collections.Generic;
using GestionAeropuertos.App.Dominio;
using System.Linq;
using System;

namespace GestionAeropuertos.App.Persistencia.AppRepositorios
{
    public class RepositorioAeropuertos
    {
        List<Aeropuerto> aeropuertos;

    public RepositorioAeropuertos()
        {
            aeropuertos= new List<Aeropuerto>()
            {
                new Aeropuerto{id=1,nombre="Aero1",ciudad= "Manizales",pais= "colombia", coordenada_x= 1, coordenada_y= 4},
                new Aeropuerto{id=2,nombre="Aero2",ciudad= "Lima",pais= "Perú", coordenada_x= 2, coordenada_y= 6},
                new Aeropuerto{id=3,nombre="Aero3",ciudad= "Madrid",pais= "España", coordenada_x= 3, coordenada_y= 10}

            };
        }

        public IEnumerable<Aeropuerto> GetAll()
        {
            return aeropuertos;
        }

        public Aeropuerto GetAeropuertoWithId(int id){
            return aeropuertos.SingleOrDefault(b => b.id == id);
        }

        public Aeropuerto Create(Aeropuerto newAeropuerto)
        {
           newAeropuerto.id=aeropuertos.Max(r => r.id) +1; 
           aeropuertos.Add(newAeropuerto);
           return newAeropuerto;
        }


       public Aeropuerto Update(Aeropuerto newAeropuerto){
            var aeropuerto= aeropuertos.SingleOrDefault(b => b.id == newAeropuerto.id);
            if(aeropuerto != null){
                aeropuerto.nombre = newAeropuerto.nombre;
                aeropuerto.ciudad = newAeropuerto.ciudad;
                aeropuerto.pais = newAeropuerto.pais;
                aeropuerto.coordenada_x = newAeropuerto.coordenada_x;
                aeropuerto.coordenada_y = newAeropuerto.coordenada_y;
            }
        return aeropuerto;
        }
 
    }
}
