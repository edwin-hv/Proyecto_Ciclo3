using System.Collections.Generic;
using GestionAeropuertos.App.Dominio;
using System.Linq;
using System;

namespace GestionAeropuertos.App.Persistencia.AppRepositorios
{
    public class RepositorioAviones
    {
        List<Avion> aviones;

    public RepositorioAviones()
        {
            aviones= new List<Avion>()
            {
                new Avion{id=1,marca="yamaha",modelo= 2000,numero_asientos= 100,numero_baños=4,capacidad_peso= 150},
                new Avion{id=2,marca="volvo",modelo= 2010,numero_asientos= 150,numero_baños=4,capacidad_peso= 200},
                new Avion{id=3,marca="suzuki",modelo= 2015,numero_asientos= 200,numero_baños=4,capacidad_peso= 250}

            };
        }

        public IEnumerable<Avion> GetAll()
        {
            return aviones;
        }

        public Avion GetAvionWithId(int id){
            return aviones.SingleOrDefault(b => b.id == id);
        }

        public Avion Create(Avion newAvion)
        {
           newAvion.id=aviones.Max(r => r.id) +1; 
           aviones.Add(newAvion);
           return newAvion;
        }


       public Avion Update(Avion newAvion){
            var avion= aviones.SingleOrDefault(b => b.id == newAvion.id);
            if(avion != null){
                avion.marca = newAvion.marca;
                avion.modelo = newAvion.modelo;
                avion.numero_asientos = newAvion.numero_asientos;
                avion.numero_baños = newAvion.numero_baños;
                avion.capacidad_peso = newAvion.capacidad_peso;
            }
        return avion;
        }
 
    }
}
