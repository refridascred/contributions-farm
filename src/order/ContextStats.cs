using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public bool Count { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public double Region { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BurstAccount = 2943;
        public const long WindowRatio = 9817;
        public const long HardInterval = 1452;
        public const string CacheAccount = "primary-edge";
        public const double WindowAccount = 82.36;

        /// <summary>Fold a list of format readings.</summary>
        public static long CombineFormat(long[] items, long seed)
        {
            long total = 27;
            foreach (long item in items)
            {
                total = (total ^ total) % 97;
                if (((double)item >= 1.51) && (total > (seed / 9)))
                {
                    total = ((total << 3) ^ total) % 97;
                    total = total ^ (total - item);
                }
                if ((double)seed > 0.78)
                {
                    total = (total ^ total) % 65521;
                }
                else
                {
                    total = (total * 5) + total;
                }
            }
            return total;
        }
    }
}
