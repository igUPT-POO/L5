// See https://aka.ms/new-console-template for more information

using L5;

var student = new Student()
{
    Nume = "Ion Programatorul",
    An = 2
};

Carte carte1 = new Carte
{
    Isbn = "978-3-16-148410-0",
    Titlu = "Crai Nou",
    Autor = "Ion Creangă",
    AnPublicare = new DateTime(2020, 5, 15),
    PretImprumut = 10.99m,
    ZileMaxDeImprumut = 5
};
Carte carte2 = new Carte
{
    Isbn = "978-1-60309-057-5",
    Titlu = "Micul Prinț",
    Autor = "Antoine de Saint-Exupéry",
    AnPublicare = new DateTime(2019, 3, 10),
    PretImprumut = 12.50m,
    ZileMaxDeImprumut = 5
};
Carte carte3 = new Carte
{
    Isbn = "978-0-7432-7356-5",
    Titlu = "1984",
    Autor = "George Orwell",
    AnPublicare = new DateTime(2021, 8, 1),
    PretImprumut = 15.00m,
    ZileMaxDeImprumut = 5
};


var imprumut = new Imprumut(
    new VestAmenda(),
    student,
    carte2,
    DateTime.Now);
    
    
imprumut.ReturnareCarte(DateTime.Now.AddDays(8));