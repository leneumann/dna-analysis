using System;
using System.Threading.Tasks;
using domain;

namespace src.domain
{
    public class DnaAnaliserService
    {
        public static bool isSimian(string[,] dnaChain)
        {
            int total = 0;
            Parallel.Invoke(() =>
            {
                total += DnaAnalizer.AnalizeDiagonally(dnaChain);
            },
            () =>
            {
                total += DnaAnalizer.AnalizeDiagonallyInverted(dnaChain);
            },
            () =>
            {
                total += DnaAnalizer.AnalizeHorizontally(dnaChain);
            },
            () =>
            {
                total += DnaAnalizer.AnalizeVertically(dnaChain);
            }
            );

            return total > 1;
        }
    }
}