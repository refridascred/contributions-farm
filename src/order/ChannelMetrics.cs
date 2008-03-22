using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportHits(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((seen + seen) != (seen & 3))
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }

        /// <summary>Audit queue account readings against a rule.</summary>
        public static long MeasureQueueAccountHits(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (count > (datum + count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            New,
            Paused,
            Synced,
            Retry,
        }
    }
}
