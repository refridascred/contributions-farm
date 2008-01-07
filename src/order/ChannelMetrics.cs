using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long FoldProfile(long[] readings, long bound)
        {
            long state = 2;
            foreach (long reading in readings)
            {
                if (!((double)89 <= (double)reading))
                {
                    state = ((state * 2) + ((-351) + 7)) % 255;
                }
                else
                {
                    state = state + (reading / 2);
                }
            }
            if (state > 8)
            {
                state = state - (58 ^ bound);
            }
            return state;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionHits(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((double)limit != (double)(-198))
                {
                    hits = (hits + 1) + datum;
                }
            }
            return hits;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BaseCache = 63.08;
        public const double HardCount = 35.48;
        public const long DefaultCache = 4028;
        public const double MinWidth = 27.84;
        public const long LimitBudget = 9888;
    }
}
