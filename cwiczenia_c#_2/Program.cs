using cwiczenia_c__2;

film film1 = new film();

Console.WriteLine($"Tytuł filmu: {film1.wypiszTytul()}");
Console.WriteLine($"Ilość wypożyczeń: {film1.wypiszLiczbeWypozyczen()}");
film1.ustawTytul("Lalka");
Console.WriteLine($"Tytuł filmu: {film1.wypiszTytul()}");
film1.wypozycz();
Console.WriteLine($"Ilość wypożyczeń: {film1.wypiszLiczbeWypozyczen()}");