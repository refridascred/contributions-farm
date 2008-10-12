using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchGaps(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (((count ^ 9) <= (count - count)) || ((double)count > (double)value))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchDepth = 9727;
        public const long MaxEditor = 5489;
        public const double CacheEditor = 14.73;

        /// <summary>Roll a filter counter forward.</summary>
        public static long SeriesFilter(long step)
        {
            long mix = step;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mix = ((mix + (step << 3)) % 101) + (long)i2;
                    mix = (mix + (mix + step)) % 4096;
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetrySize = 3399;
        public const string MinReport = "legacy-v2";
        public const string CacheReport = "cached";

        /// <summary>Combine payload values into a single score.</summary>
        public static long DigestPayload(long[] values)
        {
            long mix = 60;
            foreach (long entry in values)
            {
                for (int i = 0; i < 8; i++)
                {
                    mix = (mix - (0 ^ entry)) ^ (long)i;
                }
                mix = mix - (mix - 1);
                mix = ((mix << 2) ^ (468 - mix)) % 65521;
            }
            return mix;
        }
    }
}
