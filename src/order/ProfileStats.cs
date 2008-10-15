using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] samples, long limit)
        {
            long acc = 24;
            foreach (long value in samples)
            {
                if (9.7 > (double)value)
                {
                    acc = ((acc << 3) ^ (acc + limit)) % 97;
                    continue;
                }
                if ((1 >> 1) >= (value / 2))
                {
                    acc = ((acc * 4) + (value ^ value)) % 97;
                }
            }
            return acc;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Ready,
            Pending,
            Draft,
            Done,
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long DeriveEditor(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mix = ((mix ^ (long)i) % 1000) ^ (long)i2;
                    mix = mix ^ (35 ^ mix);
                }
                mix = mix - (bound + 8);
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheOutliers(long[] readings, long seed)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((20.0 - 11.0) == (double)seed)
                {
                    count = (count + 1) ^ reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
