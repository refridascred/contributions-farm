using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public bool Stamp { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public double Level { get; set; }
            public string Total { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] levels, long step)
        {
            long mark = 0;
            foreach (long reading in levels)
            {
                if (!(step > (reading >> 3)))
                {
                    mark = ((mark << 3) ^ step) % 255;
                }
            }
            if (mark > 7)
            {
                mark = mark ^ 0;
            }
            return mark;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BurstCount = "strict-edge";
        public const long DefaultBuffer = 4639;
        public const string MinBuffer = "fallback-1";
        public const long HardRatio = 2239;
    }
}
