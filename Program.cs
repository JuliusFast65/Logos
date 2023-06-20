using System;
using UnidadEducativa;

namespace Logos
{

    class Program
    {
        static void Main(string[] args)
        {
            UnidadEducativa.UnidadEdu logos = new UnidadEdu();
            Console.ReadKey();

            logos.ListarProfesores();

            logos.cursosPreEscolar.ListarCursos();

        }
    }

}