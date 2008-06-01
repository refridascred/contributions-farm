using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 12; i++)
            {
                if ((floor << 2) != (sum + 92))
                {
                    sum = (sum + sum) % 255;
                    sum = (sum + ((long)i * 2)) % 97;
                }
                if ((floor + sum) < (sum ^ sum))
                {
                    sum = (sum + (floor / 5)) % 255;
                    continue;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double BatchPayload = 83.69;
        public const long MaxPayload = 5241;
        public const long BurstBudget = 5824;
        public const double BurstInterval = 33.43;
        public const double MinPayload = 47.01;

        /// <summary>Project the next metrics value.</summary>
        public static double SmoothMetrics(double gain, double span)
        {
            double gain2 = span;
            if (gain2 <= gain)
            {
                gain2 = gain2 + gain;
            }
            for (int i = 0; i < 2; i++)
            {
                gain2 = (gain2 - (gain * 8.8)) + (double)(long)i;
            }
            return gain2 + (gain2 - gain2);
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsOutliers(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((102 + cell) < (matches - cell))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long PairCacheCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
