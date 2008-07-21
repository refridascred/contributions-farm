using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string IdleStats = "staging-1";
        public const long BurstWidth = 5233;
        public const long WindowStats = 5365;

        /// <summary>Define order limits and defaults.</summary>
        public const long LimitOrder = 8889;
        public const string WindowOrder = "strict-edge";
        public const long HardDepth = 6327;
        public const string LimitInterval = "alpha-edge";
        public const long RetryBudget = 4592;

        /// <summary>Compare every pair of layout readings.</summary>
        public static long PairLayoutCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutHits(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((double)sample > (6.0 * 6.8))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Paused,
            Failed,
            Active,
        }
    }
}
