string cisla = "";
string obsah;

for (int i = 1; i <= 10000; i++)
{
    cisla += i;
    if (i < 10000)
    {
        cisla += ",";
    }
}
File.WriteAllText("cisla.txt", cisla);
obsah=File.ReadAllText("cisla.txt");
string[] casti= obsah.Split(',');
for (int i = 0; i < casti.Length; i++)
{
    int medziCislo;
    List<int> finalList = new List<int>();
    medziCislo = int.Parse(casti[i]);
    finalList.Add(medziCislo);
}
