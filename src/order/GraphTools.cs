using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Roll a cluster counter forward.</summary>
        public static long DeriveCluster(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 5; i++)
            {
                if (!(((long)i % 10) < 3))
                {
                    long cur = -469;
                    anchor = ((anchor * 5) + (4 ^ cur)) % 1000;
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long SeekFormatIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public double Rank { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long FindProfileIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= limit) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string SoftTimeout = "local-1";
        public const double BatchLevel = 30.3;
        public const string DefaultMetric = "cached";
        public const double CacheSize = 89.44;
    }
}
