double NajdiMean(List<int> Zoznam1)
{
    double Cislo1 = 0;
    for(int i = 0;i<Zoznam1.Count;i++)
    {
        Cislo1 = Cislo1 + Zoznam1[i];
    }
    return Cislo1/Zoznam1.Count;
}
double NajdiMedian(List<int> Zoznam)
{
    Zoznam.Sort();
    return Zoznam[Zoznam.Count / 2];
}

int NajdiMax(List<int> Zoznam)
{
    Zoznam.Sort();
    return Zoznam[Zoznam.Count-1];
}

void volajDekorativne(double mean, double median, int max)
{
    Console.WriteLine($"Priemer zoznamu je {mean}");
    Console.WriteLine($"Median zoznamu je {median}");
    Console.WriteLine($"Maximum zoznamu je {max}");
}

List<int> Zoznam = new List<int>();
Zoznam.Add(1);
Zoznam.Add(2);
Zoznam.Add(3);
double mean = NajdiMean(Zoznam);
double median = NajdiMedian(Zoznam);
int max = NajdiMax(Zoznam);
volajDekorativne(mean,median, max);



