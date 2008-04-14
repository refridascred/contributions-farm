using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Compare every pair of support readings.</summary>
        public static long PairSupportCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyRange(long[] series, long target)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long ClassifyLayout(long target, long limit)
        {
            if (target <= (7 << 2))
            {
                return 5;
            }
            else
            {
                if ((limit << 3) <= (limit - 14))
                {
                    return 8;
                }
                else
                {
                    if (!(limit < (target - target)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (2.0 >= (double)target)
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] series, long step)
        {
            long carry = 5;
            foreach (long entry in series)
            {
                carry = ((carry * 4) + carry) + step;
                carry = ((carry << 2) ^ (carry + entry)) % 255;
            }
            if (carry < 9)
            {
                carry = (carry << 3) ^ (9 >> 1);
            }
            return carry;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long RollSession(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 4; i++)
            {
                if (!((double)mix == (double)(long)i))
                {
                    mix = (mix * 3) + (mix ^ floor);
                    mix = mix ^ ((long)i + mix);
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }
    }
}
