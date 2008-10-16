using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public double Limit { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Iterate the cache already series from a seed.</summary>
        public static long RollCacheAlready(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 24; i++)
            {
                acc = ((acc << 3) ^ acc) % 65521;
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Total { get; set; }
            public long Mode { get; set; }
            public long Flag { get; set; }
            public double Level { get; set; }
        }
    }
}
