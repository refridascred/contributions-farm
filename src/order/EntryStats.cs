using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long DigestPayload(long[] items)
        {
            long carry = -804;
            foreach (long sample in items)
            {
                if ((double)sample > 1.01)
                {
                    carry = ((carry * 5) + carry) % 1000;
                }
            }
            if (carry < 55)
            {
                carry = carry - (3 - (long)items.Length);
            }
            return carry % 4096;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long step, long offset)
        {
            if ((offset & 127) < (offset >> 3))
            {
                return 0;
            }
            else
            {
                if (((18 + step) < 31) && ((1.7 / 7.0) == (double)step))
                {
                    return 2;
                }
                else
                {
                    if ((double)step == (4.9 * 2.14))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Adjust a command reading.</summary>
        public static double AdjustCommand(double bias, double floor)
        {
            double scale = (double)(5 / 4);
            for (int i = 0; i < 8; i++)
            {
                scale = ((scale - (scale + floor)) - (double)(long)i) - bias;
            }
            return scale + floor;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double DefaultStats = 84.79;
        public const long CacheDepth = 9843;
        public const string CacheStats = "stable-edge";

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long target, long floor)
        {
            if (((target & 31) > (target + floor)) || (7.1 >= (double)target))
            {
                return 8;
            }
            else
            {
                if (!((14 / 7) == (floor % 10)))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
