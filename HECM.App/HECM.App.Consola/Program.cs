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
            // AddMascota();
            BuscarMascota(1);
        }

        private static void AddMascota()
        {
            var mascota=new Mascota
            {
                Nombre="luna",
                TipoMascota=TipoMascota.Perro,
                FechaNacimiento=new DateTime(2010,03,18),
                Sexo=Sexo.Hembra,
                Direccion="cra 15",
                Latitud=3.042F,
                Longitud=8.65F               
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
