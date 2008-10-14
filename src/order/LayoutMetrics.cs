using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public string Limit { get; set; } = "";
            public long Score { get; set; }
            public double Token { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Iterate the entry queue series from a seed.</summary>
        public static long IterateEntryQueue(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    anchor = (anchor * 4) + (long)i2;
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Iterate the commits cache series from a seed.</summary>
        public static long RollCommitsCache(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 4; i++)
            {
                if (((long)i + seed) == (mix << 3))
                {
                    mix = mix + seed;
                }
                else
                {
                    mix = ((mix << 3) ^ ((long)i % 12)) % 4096;
                }
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mix = (((mix * 3) + mix) % 1000) ^ (long)i2;
                    mix = mix - (930 ^ (long)i);
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
