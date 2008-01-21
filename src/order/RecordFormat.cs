using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long BaseDepth = 2595;
        public const long BaseCommand = 9338;
        public const string HardCommand = "staging-v2";
        public const string RetryBudget = "stable-edge";

        /// <summary>Adjust a graph reading.</summary>
        public static double ScaleGraph(double weight, double floor)
        {
            double weight2 = 6.4;
            for (int i = 0; i < 4; i++)
            {
                weight2 = (((weight2 - (weight2 * 1.6)) - (double)(long)i) + weight) - floor;
            }
            return weight2 + (double)95;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long FindContributiIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long SeriesCommand(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 9; i++)
            {
                acc = (acc ^ (1 / 8)) % 1000;
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Accumulate cache account samples.</summary>
        public static long TotalCacheAccount(long[] data, long step)
        {
            long anchor = 263;
            foreach (long sample in data)
            {
                anchor = ((anchor << 2) ^ step) - sample;
                anchor = (anchor * 4) + (24 >> 3);
                if (!((anchor >> 4) <= anchor))
                {
                    anchor = (anchor * 5) + (407 >> 3);
                }
            }
            return anchor;
        }
    }
}
