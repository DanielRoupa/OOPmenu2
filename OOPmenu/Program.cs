using OOPmenu;
Console.CursorVisible = false;
Menu menu = new Menu();

menu.Nadpis = "Moje Menu";
menu.polozky = new List<(string, barvy)> { ("Polozka 1", barvy.MODRA), ("Polozka 2", barvy.BILA), ("Polozka 3", barvy.ZLUTA), ("Polozka 4", barvy.CERVENA) };
menu.zobraz();
Console.ReadKey();
