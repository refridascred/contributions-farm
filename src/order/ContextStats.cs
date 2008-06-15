using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LookupSessionIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= seed) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Weight { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Validate stats layout readings against a bound.</summary>
        public static bool CheckStatsLayoutLimits(long[] values, long bound)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long IteratePayload(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }
    }
}
