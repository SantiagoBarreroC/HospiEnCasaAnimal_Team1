using System;
namespace HECM.App.Dominio
{
    public class Mascota
    {
        public int Id {get;set;}
        public string Nombre {get;set;}
        public TipoMascota TipoMascota {get;set;}
        public DateTime FechaNacimiento {get;set;}
        public Sexo Sexo {get;set;}
        public string Direccion {get;set;}
        public float Latitud {get;set;}
        public float Longitud {get;set;}
        public PropietarioDesignado Propietario {get;set;}
        public Veterinario Veterinario {get;set;}
        public Historia Historia {get;set;}
        public System.Collections.Generic.List<SignoVital> SignosVitales {get;set;}
    }
}