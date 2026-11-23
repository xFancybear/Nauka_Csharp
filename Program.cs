// Klasy 
namespace LabWSIZ
{

    class Osoba
    {
        public string Imie; // dobre praktyki - public pola i wlasciwosci z duzych liter
        public int Wiek;

        // konstruktor 
        public Osoba(string imie, int wiek)
        {
            Imie = imie;
            Wiek = wiek;
        }
    }

    class Student : Osoba // dziedziczenie klasy Student po klasie Osoba
    {
        public int NumerIndeksu;

        // wywolanie konstruktora klasy bazowej Osoba z konstruktora klasy Student
        public Student(string imie, int wiek) : base(imie, wiek)
        {

        }
    }


    class Test // zgodnie z dobrymi praktykami dodatkowa klasa uruchamiajaca 
    {
        static void Main()
        {
            Student student1 = new Student("Adam", 21);
            
            student1.NumerIndeksu = 12345;

            Console.WriteLine("Imie: " + student1.Imie);
            Console.WriteLine("Wiek: " + student1.Wiek);
            Console.WriteLine("Numer Indeksu: " + student1.NumerIndeksu);
        }

    }
}