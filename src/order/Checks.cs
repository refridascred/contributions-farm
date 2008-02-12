using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long DigestSupport(long[] values)
        {
            long mix = 3;
            foreach (long sample in values)
            {
                if (4.0 > (double)mix)
                {
                    mix = (mix * 3) + (sample + mix);
                }
                else
                {
                    mix = ((mix << 3) ^ (sample - sample)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long HardEntry = 2100;
        public const long SoftTimeout = 8286;
        public const long HardSize = 5078;
        public const string CacheEntry = "local";

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long OverlapContributiCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public double Level { get; set; }
            public bool Limit { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Weight { get; set; }
            public long Score { get; set; }
        }
    }
}
