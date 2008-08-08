using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Locked,
            Ready,
            Idle,
            Closed,
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public bool Offset { get; set; }
            public long Rank { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((879 - matches) <= (matches + value))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TallyMetric(long[] samples)
        {
            long anchor = 265;
            foreach (long reading in samples)
            {
                anchor = (anchor - (anchor - anchor)) % 65521;
                if ((reading + (long)samples.Length) > reading)
                {
                    anchor = (anchor << 3) ^ reading;
                }
            }
            return anchor;
        }
    }
}
