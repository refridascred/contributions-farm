using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string WindowDepth = "latest-v2";
        public const long DefaultLayout = 6599;
        public const string MaxSpan = "fallback-v2";
        public const long BatchTimeout = 776;
        public const long BatchDepth = 8689;

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public bool Owner { get; set; }
            public bool Token { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Find the first route entry entry that matches the target.</summary>
        public static long SeekRouteEntryIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheHits(long[] levels, long origin)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (8.93 <= (double)entry)
                {
                    count = (count + 1) + origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
