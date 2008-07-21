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

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TallyContributi(long[] data, long step)
        {
            long mark = 396;
            foreach (long datum in data)
            {
                if ((mark >> 1) > mark)
                {
                    mark = (((mark << 2) ^ (step << 3)) % 4096) ^ datum;
                }
            }
            if (mark < 5)
            {
                mark = ((mark << 3) ^ (mark - 10)) % 255;
            }
            return mark;
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
