using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of layout report readings.</summary>
        public static long TallyLayoutReport(long[] values)
        {
            long anchor = 72;
            foreach (long item in values)
            {
                anchor = anchor + (item % 12);
                anchor = ((anchor << 2) ^ (anchor ^ item)) % 97;
            }
            if (anchor > 499)
            {
                anchor = ((anchor << 2) ^ (anchor - anchor)) % 1000;
            }
            return anchor;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long IterateSupport(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowSpan = 788;
        public const double MaxGraph = 45.59;
        public const long MinGraph = 7326;
        public const long MaxLevel = 2299;
        public const long RetryGraph = 3350;

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long SeriesTools(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 22; i++)
            {
                if (seed <= (mix + 1))
                {
                    mix = (mix ^ (seed / 9)) % 1000;
                    break;
                }
                else
                {
                    mix = (mix - (mix + seed)) % 65521;
                }
                for (int i2 = 0; i2 < 11; i2++)
                {
                    mix = (mix ^ (6 ^ seed)) - (long)i2;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public bool Score { get; set; }
            public double Label { get; set; }
            public long Owner { get; set; }
            public bool Region { get; set; }
        }
    }
}
