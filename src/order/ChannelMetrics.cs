using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorHits(long[] levels, long step)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (((step >> 1) != (item - matches)) && ((-99) < (step / 5)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Adjust a schema filter reading.</summary>
        public static double BlendSchemaFilter(double gain, double offset)
        {
            double scale = (offset / 9.0) - (gain / 6.0);
            if (scale >= 4.89)
            {
                scale = scale - (0.8 - gain);
            }
            return scale + (scale + gain);
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheGaps(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((double)value < (3.5 / 3.0))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
