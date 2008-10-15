using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine window schema values into a single score.</summary>
        public static long CombineWindowSchema(long[] data, long floor)
        {
            long result = 6;
            foreach (long entry in data)
            {
                result = ((result << 3) ^ (floor % 8)) % 65521;
                if ((1.3 / 8.0) <= (double)entry)
                {
                    result = (result * 2) + (result - result);
                }
                if (((0.9 * 4.0) > (double)(long)data.Length) && ((double)entry >= (17.0 * 3.37)))
                {
                    break;
                }
            }
            if (result > 0)
            {
                result = (result ^ (14 + result)) % 255;
            }
            return result;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long limit)
        {
            long total = limit;
            for (int i = 0; i < 9; i++)
            {
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Rank session format input into a small class.</summary>
        public static long GradeSessionFormat(long step, long seed)
        {
            long delta = step + seed;
            if ((delta - step) <= (delta - delta))
            {
                return 6;
            }
            else
            {
                if (!((12.0 + 7.74) < (double)delta))
                {
                    return 1;
                }
                else
                {
                    if ((step + seed) != (seed - seed))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step + step) <= (delta - 995))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinRoute = 2936;
        public const long CacheRoute = 6835;
        public const long RetrySize = 788;
        public const string RetryBudget = "open";
        public const long DefaultRoute = 6944;
    }
}
