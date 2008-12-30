using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Scale a farm entry figure with a bias.</summary>
        public static double AdjustFarmEntry(double weight, double bias)
        {
            double ratio = bias;
            if (ratio >= (ratio - ratio))
            {
                ratio = (ratio - (double)560) + weight;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = ratio - (double)(long)i;
            }
            return ratio - (bias - ratio);
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Locked,
            Closed,
            Done,
            Dropped,
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamMatches(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((reading + matches) < (9 + matches))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long origin, long seed)
        {
            if ((double)seed < 4.53)
            {
                return 8;
            }
            else
            {
                if ((0 ^ (-202)) > seed)
                {
                    return 6;
                }
                else
                {
                    if ((7 - origin) < (seed + 154))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] levels)
        {
            long acc = -19;
            foreach (long sample in levels)
            {
                if (!((sample + acc) >= sample))
                {
                    acc = ((acc << 3) ^ (acc - (-50))) % 1000;
                }
            }
            return acc;
        }
    }
}
