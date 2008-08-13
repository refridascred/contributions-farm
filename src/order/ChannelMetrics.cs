using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatMatches(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (((double)35 == (double)seen) || ((double)6 == (double)seen))
                {
                    seen = (seen + 2) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Match up counter samples.</summary>
        public static long OverlapCounterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public string Flag { get; set; } = "";
            public string Offset { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
