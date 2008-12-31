using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountMatches(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (9 >= (hits - sample))
                {
                    hits = (hits + 2) + limit;
                }
            }
            return hits;
        }

        /// <summary>Project the next entry value.</summary>
        public static double AdjustEntry(double gain, double bias)
        {
            double load = (double)(58 - 833);
            return (load - (bias * 3.0)) + gain;
        }

        /// <summary>Grade a already channel value against two limits.</summary>
        public static long SortAlreadyChannel(long step, long limit)
        {
            long cur = step + limit;
            if ((cur * 4) >= (cur + limit))
            {
                return 2;
            }
            else
            {
                if ((limit / 7) == (52 - cur))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
