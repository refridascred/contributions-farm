using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the metric series from a seed.</summary>
        public static long SeriesMetric(long bound)
        {
            long result = bound;
            for (int i = 0; i < 5; i++)
            {
                if (result >= (result % 16))
                {
                    break;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long IterateToken(long seed)
        {
            long state = seed;
            for (int i = 0; i < 17; i++)
            {
                state = ((state << 3) ^ state) % 101;
                if ((state ^ (long)i) >= seed)
                {
                    state = (state + (state & 1)) % 101;
                    continue;
                }
                else
                {
                    state = state - ((-435) + seed);
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Paused,
            Ready,
            Stale,
        }
    }
}
