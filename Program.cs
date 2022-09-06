Random randomerare = new Random();
int slump_tal = randomerare.Next(1, 10);

Console.WriteLine("Gissa ett tal mellan 1 och 10!");
string str = Console.ReadLine();
int tal = Convert.ToInt32(str);

while (tal < slump_tal)

{
    Console.WriteLine("Större!");
    str = Console.ReadLine();
    tal = Convert.ToInt32(str);
}

while (tal > slump_tal)

{
    Console.WriteLine("Mindre!");
    str = Console.ReadLine();
    tal = Convert.ToInt32(str);
}

if (tal == slump_tal)

{
    Console.WriteLine("Grattis! Du gissade rätt!");
    Console.ReadLine();
}
