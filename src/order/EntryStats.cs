using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Flag { get; set; }
            public long Level { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Pending,
            Idle,
            Draft,
            Active,
            Stale,
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double SmoothNotes(double gain, double floor)
        {
            double ratio = gain;
            if (ratio <= floor)
            {
                ratio = ratio + floor;
            }
            return ratio - 1.8;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= origin) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Ready,
            Done,
            Locked,
            Synced,
            Retry,
        }
    }
}
