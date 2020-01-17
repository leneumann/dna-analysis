using System;

namespace domain
{
    public class DnaAnalizer
    {
        public static int AnalizeDiagonally(string[,] dnaChain)
        {
            int totalRows = dnaChain.GetUpperBound(0) - dnaChain.GetLowerBound(0);
            int totalCols = dnaChain.GetUpperBound(1) - dnaChain.GetLowerBound(1);
            var row = 0;
            var col = 0;
            string previousProtein = String.Empty;
            int proteinCounter = 0;
            int totalChainsFound = 0;
            for (int i = 0; i <= totalRows; i++)
            {
                row = i;
                col = 0;

                while (row >= 0 && col <= totalCols)
                {
                    if (String.IsNullOrEmpty(previousProtein))
                    {
                        previousProtein = dnaChain[row, col];
                        proteinCounter++;
                    }
                    else
                        if (dnaChain[row, col] == previousProtein)
                        proteinCounter++;
                    else
                    {
                        proteinCounter = 1;
                        previousProtein = dnaChain[row, col];
                    }

                    if (proteinCounter == 4)
                        totalChainsFound++;
                    row -= 1;
                    col += 1;
                }
                proteinCounter = 0;
                previousProtein = String.Empty;
            }

            for (int i = 1; i <= totalCols; i++)
            {
                row = totalRows;
                col = i;

                while (row >= 0 && col <= totalCols)
                {
                    if (String.IsNullOrEmpty(previousProtein))
                    {
                        previousProtein = dnaChain[row, col];
                        proteinCounter++;
                    }
                    else
                        if (dnaChain[row, col] == previousProtein)
                        proteinCounter++;
                    else
                    {
                        proteinCounter = 1;
                        previousProtein = dnaChain[row, col];
                    }

                    if (proteinCounter == 4)
                        totalChainsFound++;

                    row -= 1;
                    col += 1;
                }
                proteinCounter = 0;
                previousProtein = String.Empty;
            }
            return totalChainsFound;
        }

        public static int AnalizeDiagonallyInverted(string[,] dnaChain)
        {
            int totalRows = dnaChain.GetUpperBound(0) - dnaChain.GetLowerBound(0);
            int totalCols = dnaChain.GetUpperBound(1) - dnaChain.GetLowerBound(1);
            var row = 0;
            var col = 0;
            string previousProtein = String.Empty;
            int proteinCounter = 0;
            int totalChainsFound = 0;

            for (int i = 0; i <= totalRows; i++)
            {
                row = i;
                col = totalCols;

                while (row >= 0 && col >= 0)
                {
                    if (String.IsNullOrEmpty(previousProtein))
                    {
                        previousProtein = dnaChain[row, col];
                        proteinCounter++;
                    }
                    else
                         if (dnaChain[row, col] == previousProtein)
                        proteinCounter++;
                    else
                    {
                        proteinCounter = 1;
                        previousProtein = dnaChain[row, col];
                    }

                    if (proteinCounter == 4)
                        totalChainsFound++;
                    row -= 1;
                    col -= 1;
                }
                proteinCounter = 0;
                previousProtein = String.Empty;
            }

            for (int i = totalCols - 1; i >= 0; i--)
            {
                row = totalRows;
                col = i;

                while (col >= 0 && row >= 0)
                {
                    if (String.IsNullOrEmpty(previousProtein))
                    {
                        previousProtein = dnaChain[row, col];
                        proteinCounter++;
                    }
                    else
                        if (dnaChain[row, col] == previousProtein)
                        proteinCounter++;
                    else
                    {
                        proteinCounter = 1;
                        previousProtein = dnaChain[row, col];
                    }

                    if (proteinCounter == 4)
                        totalChainsFound++;
                    row -= 1;
                    col -= 1;
                }
                proteinCounter = 0;
                previousProtein = String.Empty;
            }
            return totalChainsFound;
        }

        public static int AnalizeHorizontally(string[,] dnaChain)
        {
            int totalRows = dnaChain.GetUpperBound(0) - dnaChain.GetLowerBound(0);
            int totalCols = dnaChain.GetUpperBound(1) - dnaChain.GetLowerBound(1);
            var row = 0;
            var col = 0;
            string previousProtein = String.Empty;
            int proteinCounter = 0;
            int totalChainsFound = 0;

            for (row = 0; row <= totalRows; row++)
            {
                for (col = 0; col <= totalCols; col++)
                {
                    if (String.IsNullOrEmpty(previousProtein))
                    {
                        previousProtein = dnaChain[row, col];
                        proteinCounter++;
                    }
                    else
                        if (dnaChain[row, col] == previousProtein)
                        proteinCounter++;
                    else
                    {
                        proteinCounter = 1;
                        previousProtein = dnaChain[row, col];
                    }
                    if (proteinCounter == 4)
                        totalChainsFound++;
                }
                proteinCounter = 0;
                previousProtein = String.Empty;
            }
            return totalChainsFound;
        }

        public static int AnalizeVertically(string[,] dnaChain)
        {
            int totalRows = dnaChain.GetUpperBound(0) - dnaChain.GetLowerBound(0);
            int totalCols = dnaChain.GetUpperBound(1) - dnaChain.GetLowerBound(1);
            var row = 0;
            var col = 0;
            string previousProtein = String.Empty;
            int proteinCounter = 0;
            int totalChainsFound = 0;

            for (col = 0; col <= totalCols; col++)
            {
                for (row = 0; row <= totalRows; row++)
                {
                    if (String.IsNullOrEmpty(previousProtein))
                    {
                        previousProtein = dnaChain[row, col];
                        proteinCounter++;
                    }
                    else
                        if (dnaChain[row, col] == previousProtein)
                        proteinCounter++;
                    else
                    {
                        proteinCounter = 1;
                        previousProtein = dnaChain[row, col];
                    }
                    if (proteinCounter == 4)
                        totalChainsFound++;
                }
                proteinCounter = 0;
                previousProtein = String.Empty;
            }

            return totalChainsFound;
        }
    }
}