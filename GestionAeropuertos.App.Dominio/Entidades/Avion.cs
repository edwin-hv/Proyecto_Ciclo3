using System;

namespace GestionAeropuertos.App.Dominio
{
    public class Avion
    {
        public int id{get;set;}
        public string marca{get;set;}
        public int modelo{get;set;}
        public int numero_asientos{get;set;}
        public int numero_baños{get;set;}
        public int capacidad_peso{get;set;}
    }
}
