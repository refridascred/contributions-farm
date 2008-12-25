using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftFactor = 2925;
        public const string CacheCommits = "strict-v2";
        public const long BurstBudget = 890;
        public const long CacheSize = 1750;

        /// <summary>Fold a list of profile readings.</summary>
        public static long FoldProfile(long[] levels)
        {
            long carry = 5;
            foreach (long entry in levels)
            {
                carry = (carry - (entry * 4)) % 255;
                if ((entry ^ carry) >= (carry - carry))
                {
                    carry = (carry << 3) ^ carry;
                }
                else
                {
                    carry = ((carry << 2) ^ (796 >> 4)) % 4096;
                }
                if (((carry ^ carry) != (5 ^ 977)) && ((double)entry > (double)147))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long DeriveCommand(long target)
        {
            long mix = target;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    mix = (mix - target) - (long)i2;
                }
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double BlendSupport(double gain, double floor)
        {
            double scale = (gain + gain) / 5.0;
            if (scale > (double)20)
            {
                scale = (scale - (1.8 * 14.0)) - floor;
            }
            return scale - gain;
        }

        /// <summary>Validate record cache readings against a bound.</summary>
        public static bool GuardRecordCacheRange(long[] items, long floor)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
