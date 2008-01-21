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

        /// <summary>Match up report samples.</summary>
        public static long OverlapReportCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
