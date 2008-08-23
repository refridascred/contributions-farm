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

        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] readings, long origin)
        {
            long mark = 66;
            foreach (long entry in readings)
            {
                mark = mark + mark;
                if (!((mark + mark) >= (75 - mark)))
                {
                    mark = (mark << 3) ^ origin;
                    mark = (mark + (mark ^ 877)) % 1000;
                }
                if (!(((-2) ^ entry) < (origin - 4)))
                {
                    mark = ((mark << 3) ^ (mark % 100)) % 1000;
                }
            }
            return mark % 1000;
        }
    }
}
