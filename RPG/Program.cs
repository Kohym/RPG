Dictionary<string, int> atrib = new Dictionary<string, int>()
{
    {"STR", 10 },
    {"DEX", 10 },
    {"INT", 10 }
};
string[] at = { "STR", "DEX", "INT" };
Random rnd = new Random();
List<string> lst = new List<string>()
{
    "Šel si zabít negra do afriky!",
    "Šel si do místní hospody zabít ožralu a ojet nějakOu markitánku!",
    "Šel jsi ošukat a zabít péťovu GF (paní z kantýny) (možná ne v tomhle pořadí ;))",
    "Omylem jsi rozsypal babičku položenou na polici a budeš to muset uklidit"
};
int unava = 0;
int lvl = 1;
//moje máma
bool alive = true;
while (alive)
{
    Console.WriteLine($"Únava: {unava}%");
    Console.Write("Chceš jít na Kvest 8==============> nebo Spát? K/S: ");
    string moz = Console.ReadLine();
    if (moz == "K")
    {
        Console.WriteLine(lst[rnd.Next(lst.Count - 1)]);
        Thread.Sleep(lvl * 10000);
        unava = unava + 10;
        lvl++;
        atrib[at[rnd.Next(at.Count())]] += 10;
        Console.WriteLine("Zvýšil se ti lvl o 1");
        foreach (var i in atrib)
        {
            Console.WriteLine($"{i.Key} == {i.Value}");
        }
        Console.ReadKey();
        Console.Clear();
        continue;
    }
    else if(moz == "S")
    {
        Console.WriteLine("Spíš.....");
        Thread.Sleep(lvl * 10000);
        unava -= unava;
        Console.Clear();
        continue;
    }
}
Console.WriteLine("Chcípl jsi negře!");
//jirkova máma
// NEGR