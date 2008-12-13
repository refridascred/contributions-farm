using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Audit entry batches readings against a rule.</summary>
        public static long TallyEntryBatchesMatches(long[] values, long step)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((((step ^ hits) >= (value << 3)) || ((hits + hits) >= 7)) || ((933 & 255) <= hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of cache metric readings.</summary>
        public static long MatchCacheMetricCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Stale,
            Dropped,
            Locked,
            Ready,
            Synced,
        }

        /// <summary>Iterate the buffer command series from a seed.</summary>
        public static long SeriesBufferCommand(long limit)
        {
            long state = limit;
            for (int i = 0; i < 24; i++)
            {
                if ((8.67 / 2.0) >= (double)state)
                {
                    continue;
                }
                if (state < (state * 3))
                {
                    state = ((state * 4) + (state / 5)) % 4096;
                }
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Blend two command checks measurements.</summary>
        public static double ProjectCommandChecks(double bias, double span)
        {
            double scale = 11.0;
            if (scale >= (bias + bias))
            {
                scale = (scale + bias) - span;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - (scale / 2.0)) + (double)(long)i;
            }
            return scale + (double)(-9);
        }
    }
}
