using System.Security.Authentication;

class Osoba
{

        
    
    string imie;
    string nazwisko;
    string kod;
    string adres;
    string miasto;
    public void wczytaj()
    {
        Console.WriteLine("Podaj imię: ");
        imie = Console.ReadLine();
        Console.WriteLine("Podaj nazwisko: ");
        nazwisko = Console.ReadLine();
        Console.WriteLine("Podaj kod pocztowy: ");
        kod = Console.ReadLine();
        Console.WriteLine("Podaj adres: ");
        adres = Console.ReadLine();
        Console.WriteLine("Podaj miasto: ");
        miasto = Console.ReadLine();
    }
    public void wyswietl()
    {
        Console.WriteLine("Imię: " + imie);
        Console.WriteLine("Nazwisko: " + nazwisko);
        Console.WriteLine("Kod pocztowy: " + kod);
        Console.WriteLine("Adres: " + adres);
        Console.WriteLine("Miasto: " + miasto);

    }

    static void Main(string[] args)
    {
        
        Kadra kadra = new Kadra();
        
        kadra.wczytaj1();
        
        kadra.wyswietl1();
        
        
    }
}
class Kadra : Osoba
{
    string stanowisko;
    string wyksztalcenie;
    public void wczytaj1()
    {
        wczytaj();
        Console.WriteLine("Podaj stanowisko: ");
        stanowisko = Console.ReadLine();
        Console.WriteLine("Podaj wykształcenie: ");
        wyksztalcenie = Console.ReadLine();
    }

    public void wyswietl1()
    {

        wyswietl();
    Console.WriteLine("Stanowisko: " + stanowisko);
        Console.WriteLine("Wykształcenie: " + wyksztalcenie);


    }
}