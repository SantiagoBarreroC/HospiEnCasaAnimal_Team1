using System;
using HECM.App.Dominio;
using HECM.App.Persistencia;

namespace HECM.App.Consola
{
    class Program
    {   private static IRepositorioMascota _repoMascota=new RepositorioMascota(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World E!");
            //AddMascota();
            //BuscarMascota(1);
        }

        private static void AddMascota()
        {
            var mascota=new Mascota
            {
                Nombre="Joky",
                TipoMascota=TipoMascota.Gato,
                FechaNacimiento=new DateTime(2016,09,03),
                Sexo=Sexo.Macho,
                Direccion="cra 25 calle 6",
                Latitud=8.045F,
                Longitud=2.05F               
            };
            _repoMascota.AddMascota(mascota);
        }

        private static void BuscarMascota(int IdMascota)
        {
            var mascota= _repoMascota.GetMascota(IdMascota);
            Console.WriteLine(mascota.Nombre);
        }

    }
}
