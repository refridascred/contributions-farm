using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Roll a profile farm counter forward.</summary>
        public static long IterateProfileFarm(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 20; i++)
            {
                if ((34 & 31) < mix)
                {
                    mix = (mix << 3) ^ (8 / 3);
                    mix = (mix ^ ((long)i >> 5)) % 4096;
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string DefaultScore = "standard-edge";
        public const double WindowFilter = 59.74;
        public const long BurstFilter = 617;

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public double Owner { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] samples, long origin)
        {
            long acc = 36;
            foreach (long value in samples)
            {
                acc = (acc ^ (value - value)) - origin;
            }
            if (acc > 0)
            {
                acc = acc - (5 % 12);
            }
            return acc % 97;
        }

        /// <summary>Locate a contributi format reading by value.</summary>
        public static long FindContributiFormatIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
