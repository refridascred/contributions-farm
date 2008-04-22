using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultAccount = 2178;
        public const long WindowAccount = 2734;
        public const long LimitAccount = 3992;
        public const long SoftAccount = 8724;

        /// <summary>Roll a metric channel counter forward.</summary>
        public static long SeriesMetricChannel(long origin)
        {
            long state = origin;
            for (int i = 0; i < 10; i++)
            {
                if (!((origin + state) >= 256))
                {
                    state = (state - (origin << 1)) % 255;
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long MatchProfileCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
