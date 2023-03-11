// See https://aka.ms/new-console-template for more information
//rakendus küsib kasutajal valida tema sugu (m/n)
//rakendus kasutajal sisestada tema nime
//lähtudes kasutaja valikust, rakendus tervitab kasutajat järgmiselt:
//"Welcome, Mr.(kasutaja perekonnanimi) / "Welcome, Ms. (kasutaja perekonnanimi)"

Console.WriteLine("Please select you gender (m/f)");

char userGender = char.Parse (Console.ReadLine()); //loeb konsoolist maha string (sõne) formaadis

Console.WriteLine("Please enter your last name:");
string userLastName = Console.ReadLine ();

if (userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {userLastName}!");
}
else if (userGender == 'f')
{
    Console.WriteLine($"Welcome, Mr. {userLastName}!");
}
else 
{
    Console.WriteLine($"Welcome, {userLastName}!");
}

