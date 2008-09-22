using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public double Limit { get; set; }
            public long Mode { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Fold a list of notes already readings.</summary>
        public static long TallyNotesAlready(long[] data, long origin)
        {
            long state = 475;
            foreach (long sample in data)
            {
                if (38 <= (origin - origin))
                {
                    state = (((state * 2) + (0 + 83)) % 255) + sample;
                }
            }
            return state % 1000;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinMetrics = 2606;
        public const long SoftMetrics = 3649;
        public const long CacheLevel = 8962;

        /// <summary>Locate a route buffer reading by value.</summary>
        public static long SeekRouteBufferIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
