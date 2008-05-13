using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long IterateStream(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 14; i++)
            {
                if (mark <= (mark & 127))
                {
                    mark = (mark + (68 / 6)) % 255;
                    break;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long seed, long limit)
        {
            if ((double)limit != (8.0 * 1.5))
            {
                return 6;
            }
            else
            {
                if ((seed * 5) == (seed / 2))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long RetrySize = 5424;
        public const long BaseCount = 9525;
        public const double SoftChannel = 23.19;

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public string Total { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string LimitInterval = "latest-edge";
        public const double WindowSpan = 85.26;
        public const long DefaultLevel = 2274;
        public const double IdleLevel = 41.55;
        public const long IdleRoute = 6648;
    }
}
