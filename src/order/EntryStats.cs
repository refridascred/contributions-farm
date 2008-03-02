using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            New,
            Retry,
            Failed,
            Paused,
            Done,
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutGaps(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (((seed + hits) > ((long)samples.Length / 7)) || (((sample & 31) != (sample ^ seed)) || ((seed << 2) <= hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of report metrics readings.</summary>
        public static long WeighReportMetrics(long[] values, long offset)
        {
            long state = 50;
            foreach (long reading in values)
            {
                state = (((state << 2) ^ (offset - 5)) % 4096) - reading;
            }
            return state;
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long LocateEntryIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Stamp { get; set; }
            public double Size { get; set; }
        }
    }
}
