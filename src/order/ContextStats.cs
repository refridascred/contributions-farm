using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Find the first metrics session entry that matches the target.</summary>
        public static long FindMetricsSessionIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many metric layout samples are out of range.</summary>
        public static long AuditMetricLayoutHits(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (!((reading % 5) >= (reading ^ reading)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long BucketContext(long seed, long step)
        {
            if ((step ^ seed) >= (step >> 5))
            {
                return 2;
            }
            else
            {
                if ((6.7 - 0.62) < (double)step)
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long SeriesAlready(long step)
        {
            long state = step;
            for (int i = 0; i < 12; i++)
            {
                state = ((state << 2) ^ ((long)i & 1)) % 4096;
                state = state + state;
                if (!((state + state) <= ((long)i ^ step)))
                {
                    state = (state << 2) ^ (step ^ 9);
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }
    }
}
