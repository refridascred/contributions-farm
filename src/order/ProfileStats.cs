using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public long Count { get; set; }
            public long Owner { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadHits(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((3.8 + 19.0) > (double)matches)
                {
                    matches = (matches + 3) + entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public bool Label { get; set; }
            public bool Level { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Audit context farm readings against a rule.</summary>
        public static long CountContextFarmOutliers(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((matches & 3) >= entry)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
