using System;

/* MC = 0,6 * MNDP + 0,4 * MNEA
MC - mediei de concurs(calculată cu trunchiere până la sutimi).
MNDP - media notelor anuale la 4 disciplini de profil.
MNEA - media notelor de la examenele de absolvire. */

class Ex1
{
    public static void Main()
    {

        double MC, MNDP, MNEA;
        double m1, m2, m3, m4, e1, e2, e3;

        Console.WriteLine("INTRODUCETI MEDIILE DE PROFIL");

        Console.WriteLine("Introdu media la primul obiect de profil: ");
        string m1_str = Console.ReadLine();
        m1 = Convert.ToDouble(m1_str);

        Console.WriteLine("Introdu media la al doilea obiect de profil: ");
        string m2_str = Console.ReadLine();
        m2 = Convert.ToDouble(m2_str);

        Console.WriteLine("Introdu media la al treilea obiect de profil: ");
        string m3_str = Console.ReadLine();
        m3 = Convert.ToDouble(m3_str);

        Console.WriteLine("Introdu media la al patrulea obiect de profil: ");
        string m4_str = Console.ReadLine();
        m4 = Convert.ToDouble(m4_str);

        Console.WriteLine();

        Console.WriteLine("INTRODUCETI MEDIILE LA EXAMENE");

        Console.WriteLine("Introdu media la primul examen: ");
        string e1_str = Console.ReadLine();
        e1 = Convert.ToDouble(e1_str);

        Console.WriteLine("Introdu media la al doilea examen: ");
        string e2_str = Console.ReadLine();
        e2 = Convert.ToDouble(e2_str);

        Console.WriteLine("Introdu media la al treilea examen: ");
        string e3_str = Console.ReadLine();
        e3 = Convert.ToDouble(e3_str);

        Console.WriteLine();

        MNDP = (m1 + m2 + m3 + m4) / 4;
        Console.WriteLine("MNDP: " + MNDP);
        MNEA = (e1 + e2 + e3) / 3;
        Console.WriteLine("MNEA: " + MNEA);
        MC = (0.6 * MNDP) + (0.4 * MNEA);

        Console.WriteLine("MEDIA DE CONCURS LA ADMITERE: " + MC);

    }
}