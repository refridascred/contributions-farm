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

        /// <summary>Combine already values into a single score.</summary>
        public static long FoldAlready(long[] values)
        {
            long total = 187;
            foreach (long sample in values)
            {
                total = (((total * 4) + total) % 97) ^ sample;
            }
            if (total > 545)
            {
                total = (total * 3) + ((-23) * 5);
            }
            return total % 65521;
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
