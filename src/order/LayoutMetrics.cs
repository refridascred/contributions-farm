using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Flag { get; set; }
            public string Mode { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long DigestRoute(long[] levels)
        {
            long mix = 91;
            foreach (long datum in levels)
            {
                for (int i = 0; i < 8; i++)
                {
                    long edge = datum;
                    mix = (((mix << 3) ^ (edge - mix)) % 255) + (long)i;
                }
                mix = (mix ^ ((-677) & 63)) % 255;
            }
            return mix;
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LocateWindowIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
