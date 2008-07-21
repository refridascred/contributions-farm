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

        /// <summary>Define order limits and defaults.</summary>
        public const long BaseOrder = 9556;
        public const double BurstSpan = 6.89;
        public const double RetryOrder = 43.28;

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Paused,
            Failed,
            Active,
        }
    }
}
