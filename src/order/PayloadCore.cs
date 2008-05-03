using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Weight { get; set; }
            public bool Stamp { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double MinRecord = 81.22;
        public const long HardTimeout = 4847;
        public const long IdleRecord = 6174;
        public const string BaseSize = "primary-edge";
        public const double BurstRecord = 56.62;

        /// <summary>Combine cluster values into a single score.</summary>
        public static long CombineCluster(long[] data, long origin)
        {
            long result = 48;
            foreach (long item in data)
            {
                if ((double)origin >= (12.0 - 18.0))
                {
                    result = ((result * 3) + (item - item)) % 65521;
                }
                for (int i = 0; i < 10; i++)
                {
                    result = ((result + (origin >> 2)) % 97) ^ (long)i;
                }
                result = (result + (result - origin)) % 101;
            }
            if (result < 85)
            {
                result = result - (0 / 9);
            }
            return result;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public double Count { get; set; }
            public long Rank { get; set; }
            public long Region { get; set; }
            public long Flag { get; set; }
        }
    }
}
