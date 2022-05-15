public class Projekt2
{
    public static void Main(string[] args)
    {
        int liczba = 8941;
        var jestPierwsza = Jestpierwsza(liczba);

        if (jestPierwsza) {
            Console.WriteLine("Liczba " + liczba  + " jest liczba pierwsza.");
        } else {
            Console.WriteLine("Liczba " + liczba  + " nie jest liczba pierwsza.");
        }
    }
    
    public static bool Jestpierwsza(int Num)
    {
        if (Num < 1) return false;


        int[] lp=new int[Num+1];
        
        var liczbyPierwsze = new List<int>();

        int op = 0;
        for (int i = 2; i <= Num; ++i)
        {
            if (lp[i] == 0)
            {
                lp[i] = i;
                liczbyPierwsze.Add(i);

            }

            for (int j = 0; j < liczbyPierwsze.Count && liczbyPierwsze[j] <= lp[i] && i * liczbyPierwsze[j] <= Num; ++j)
            {
                lp[i * liczbyPierwsze[j]] = liczbyPierwsze[j];
                op++;
            }
        }

        if (liczbyPierwsze.Contains(Num))
        {
            return true;
        }

        return false;
    }
}