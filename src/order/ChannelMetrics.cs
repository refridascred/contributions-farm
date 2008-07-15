using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Failed,
            Active,
            Locked,
            Stale,
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphGaps(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (3 <= (datum << 2))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaGaps(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (((17.0 + 3.6) != (double)seen) || (reading >= seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
