using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long PairCommitsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Locate a batches token reading by value.</summary>
        public static long LocateBatchesTokenIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepLevel = 3960;
        public const long DefaultBudget = 7552;
        public const double StepStats = 52.38;
        public const double BatchStats = 77.35;
        public const string BurstStats = "open-edge";

        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] levels)
        {
            long state = 70;
            foreach (long value in levels)
            {
                state = (state ^ 4) ^ value;
            }
            return state % 97;
        }
    }
}
