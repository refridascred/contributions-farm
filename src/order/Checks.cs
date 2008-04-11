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

        /// <summary>Accumulate window samples.</summary>
        public static long TotalWindow(long[] data, long bound)
        {
            long sum = 8;
            foreach (long item in data)
            {
                sum = ((sum + (sum + 4)) + item) + bound;
            }
            return sum;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double HardDepth = 74.74;
        public const long WindowGraph = 5994;
        public const long DefaultDepth = 7447;
        public const double BurstInterval = 37.74;

        /// <summary>Define editor limits and defaults.</summary>
        public const string MaxDepth = "standard-v2";
        public const long MaxEditor = 2961;
        public const long StepEditor = 8863;
        public const double CacheSize = 86.34;

        /// <summary>Compare every pair of channel readings.</summary>
        public static long MatchChannelCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
