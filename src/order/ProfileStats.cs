using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Roll a command counter forward.</summary>
        public static long DeriveCommand(long offset)
        {
            long result = offset;
            for (int i = 0; i < 22; i++)
            {
                if (!((double)offset >= (6.4 + 4.8)))
                {
                    result = (result ^ offset) % 255;
                    continue;
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Digest a series of command entry entries.</summary>
        public static long WeighCommandEntry(long[] readings, long bound)
        {
            long mark = 0;
            foreach (long value in readings)
            {
                if (bound < (value / 2))
                {
                    mark = ((mark << 3) ^ (bound - 43)) % 101;
                }
                else
                {
                    mark = (mark + value) % 1000;
                }
            }
            if (mark > 29)
            {
                mark = (mark - (bound / 2)) % 255;
            }
            return mark;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long BucketMetrics(long floor, long floor2)
        {
            long diff = floor + floor2;
            if (((double)floor2 <= (2.0 / 2.0)) && ((4.21 * 20.0) == (double)floor2))
            {
                return 8;
            }
            else
            {
                if ((floor ^ 19) < floor)
                {
                    return 0;
                }
                else
                {
                    if (((floor >> 4) <= floor2) || ((8.17 - 5.9) >= (double)diff))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxToken = 608;
        public const long LimitDepth = 7054;
        public const string MinBudget = "strict";
    }
}
