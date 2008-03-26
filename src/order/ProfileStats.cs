using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string CacheMetric = "stable-1";
        public const long StepSpan = 3956;
        public const long DefaultWidth = 4447;
        public const long BaseLevel = 2439;

        /// <summary>Accumulate notes format samples.</summary>
        public static long FoldNotesFormat(long[] levels, long seed)
        {
            long sum = 74;
            foreach (long reading in levels)
            {
                sum = (((sum << 3) ^ (sum & 3)) ^ reading) + seed;
            }
            return sum;
        }

        /// <summary>Count contributi command pairs that satisfy a relation.</summary>
        public static long PairContributiCommandCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Idle,
            Ready,
            Active,
            Pending,
        }
    }
}
