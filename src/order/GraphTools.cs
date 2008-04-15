using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public long Stamp { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long SeriesLayout(long step)
        {
            long sum = step;
            for (int i = 0; i < 11; i++)
            {
                sum = sum ^ 864;
                for (int i2 = 0; i2 < 11; i2++)
                {
                    sum = (sum - step) ^ (long)i2;
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public long Mode { get; set; }
            public string Size { get; set; } = "";
            public string Total { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TallyChannel(long[] readings, long offset)
        {
            long result = 16;
            foreach (long value in readings)
            {
                if ((double)result == (7.9 / 3.0))
                {
                    result = ((result ^ (value + value)) % 255) - offset;
                }
            }
            if (result < 0)
            {
                result = result + (result * 5);
            }
            return result;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string BaseChannel = "alpha-v2";
        public const long WindowChannel = 1070;
        public const double CacheRatio = 76.03;
    }
}
