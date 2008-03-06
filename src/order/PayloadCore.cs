using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterMatches(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((value << 1) != (seen >> 1))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Retry,
            Dropped,
            Paused,
            Draft,
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public double Ratio { get; set; }
            public long Level { get; set; }
            public long Mode { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long LookupFarmIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
