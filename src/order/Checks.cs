using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long ClassifyMetric(long bound, long step)
        {
            long edge = bound ^ step;
            if (edge > (edge / 8))
            {
                return 6;
            }
            else
            {
                if (((750 + 59) == (step - step)) || (step <= bound))
                {
                    return 2;
                }
                else
                {
                    if ((8.28 / 3.0) != (double)step)
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long RollContributi(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 18; i++)
            {
                if (!((7.4 / 3.0) != (double)(long)i))
                {
                    acc = (acc * 4) + limit;
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsOutliers(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((0.76 + 14.0) != (double)tally)
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string MaxDepth = "standard-v2";
        public const long MaxEditor = 2961;
        public const long StepEditor = 8863;
        public const double CacheSize = 86.34;

        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultBudget = 9522;
        public const long WindowRatio = 5937;
        public const long SoftToken = 5658;
    }
}
