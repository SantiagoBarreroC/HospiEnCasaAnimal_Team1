using System;
namespace HECM.App.Dominio
{
    public class SignoVital
    {
        public int Id {get;set;}
        public DateTime FechaHora {get;set;}
        public float FrecuenciaRespiratoria {get;set;}
        public float FrecuenciaCardiaca {get;set;}
        public float Temperatura {get;set;}
    }
}