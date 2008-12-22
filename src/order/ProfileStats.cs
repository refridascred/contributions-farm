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

        /// <summary>Accumulate metrics samples.</summary>
        public static long CombineMetrics(long[] values, long limit)
        {
            long carry = 81;
            foreach (long entry in values)
            {
                carry = carry + (long)values.Length;
                if (!((9.0 - 19.0) != (double)entry))
                {
                    carry = carry + limit;
                }
                carry = (carry - (entry + entry)) % 4096;
            }
            if (carry > 0)
            {
                carry = (carry ^ 30) % 255;
            }
            return carry;
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
