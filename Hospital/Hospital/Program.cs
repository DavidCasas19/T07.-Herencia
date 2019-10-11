using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            Paciente pac = new Paciente();
            pac.Nombre = "David";
            pac.FN = "18/02/200";
            pac.Tel = "662342423084";
            Console.WriteLine(pac.Nombre + "  " + pac.FN + "  " + pac.Tel);
            Console.WriteLine("  ");
            Console.ReadKey();


            Enfermera Enf = new Enfermera();
            Enf.Nombre = "Maria";
            Enf.FN = "1283018309";
            Enf.Tel = "6644857920";
            Enf.Area = "Enfermeria";
            Console.WriteLine(Enf.Nombre + "  " + Enf.FN + "  " + Enf.Tel + " " + Enf.Area);
            Console.WriteLine("  ");
            Console.ReadKey();

            Mujer muj = new Mujer();
            muj.Nombre = "lyss";
            muj.FN = "19/12/2001";
            muj.Tel = "6654001982";
            muj.Enfermedad = "Dolor de cabeza";
            Console.WriteLine(muj.Nombre + "  " + muj.FN + "  " + muj.Tel);
            Console.WriteLine("  ");
            Console.ReadKey();

            Hombre hom = new Hombre();
            hom.Nombre = "Miguel";
            hom.FN = "21/04/2009";
            hom.Tel = "6645414212";
            hom.Enfermedad = "Gripe";
            Console.WriteLine(hom.Nombre + "  " + hom.FN + "  " + hom.Tel);
            Console.WriteLine("  ");
            Console.ReadKey();

            Fisioterapeuta fis = new Fisioterapeuta();
            fis.Nombre = "Ricardo";
            fis.FN = "20/09/1995";
            fis.Tel = "6640875472";
            fis.Especialidad ="Fisioterapeuta";
            Console.WriteLine(fis.Nombre + "  " + fis.FN + "  " + fis.Tel+" "+fis.Especialidad);
            Console.WriteLine("  ");
            Console.ReadKey();

            Familiar fam = new Familiar();
            fam.Nombre = "Fernando";
            fam.FN = "12/10/1970";
            fam.Tel = "6645940767";
            fam.Especialidad = "Medico Familiar";
            Console.WriteLine(fam.Nombre + "  " + fam.FN + "  " + fam.Tel + " " + fam.Especialidad);
            Console.WriteLine("  ");
            Console.ReadKey();

            Cirujano Cir = new Cirujano();
            Cir.Nombre = "Omar";
            Cir.FN = "15/20/1974";
            Cir.Tel = "6649762912";
            Cir.Especialidad = "Cirujano";
            Console.WriteLine(Cir.Nombre + "  " + Cir.FN + "  " + Cir.Tel + " " + Cir.Especialidad);
            Console.WriteLine("  ");
            Console.ReadKey();

            Medico med = new Medico();
            med.Nombre = "Fernando";
            med.FN = "12/10/1970";
            med.Tel = "61241454127";
            med.Especialidad = "Medico general";
            Console.WriteLine(med.Nombre + "  " + med.FN + "  " + med.Tel + " " + med.Especialidad);
            Console.WriteLine("  ");
            Console.ReadKey();





        }
    }
}
