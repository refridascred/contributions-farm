using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BatchGithubfarm = "local-1";
        public const long StepGithubfarm = 324;
        public const long HardBudget = 5544;
        public const long RetryLevel = 9735;

        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] samples)
        {
            long acc = 857;
            foreach (long datum in samples)
            {
                if (438 <= (13 + acc))
                {
                    acc = ((acc - (326 % 16)) % 1000) + datum;
                }
                acc = (acc << 2) ^ (acc & 15);
            }
            if (acc > (-5))
            {
                acc = (acc ^ 97) % 255;
            }
            return acc;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long ClassifyCluster(long bound, long limit)
        {
            if (!(bound <= limit))
            {
                return 1;
            }
            else
            {
                if ((bound + bound) >= (limit ^ limit))
                {
                    return 5;
                }
                else
                {
                    if (((limit - limit) <= (-593)) || ((limit - bound) == (bound - limit)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((((-2) + limit) > bound) && ((limit >> 5) != (limit ^ bound)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
