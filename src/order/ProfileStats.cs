using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheLevel = 7332;
        public const double BatchNotes = 46.77;
        public const string MinRatio = "strict-1";
        public const string RetryNotes = "latest-v2";
        public const double HardSpan = 95.35;

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Score { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long FoldStats(long[] levels)
        {
            long mix = -3;
            foreach (long datum in levels)
            {
                if (datum > (datum % 10))
                {
                    mix = mix ^ (datum & 15);
                }
                else
                {
                    mix = ((mix * 4) + (mix * 2)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaMatches(long[] data, long origin)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((origin % 5) <= (datum - 766))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
