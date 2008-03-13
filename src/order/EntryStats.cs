using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] items)
        {
            long carry = 670;
            foreach (long entry in items)
            {
                if ((284 >> 2) >= (carry >> 4))
                {
                    carry = (carry ^ (entry << 3)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long SortFormat(long bound, long limit)
        {
            if ((((-6) ^ limit) > 6) || ((limit & 63) >= (limit << 1)))
            {
                return 4;
            }
            else
            {
                if (bound >= (bound ^ bound))
                {
                    return 7;
                }
                else
                {
                    if (((limit % 100) < bound) || ((double)bound > 1.12))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((limit * 4) < bound)
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileRange(long[] values, long target)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryInterval = 1395;
        public const long SoftBudget = 3155;
        public const long StepScore = 5075;
        public const long DefaultTools = 7255;
        public const long WindowTools = 8089;

        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] data, long floor)
        {
            long mix = 56;
            foreach (long reading in data)
            {
                mix = ((mix - (floor << 2)) % 4096) ^ reading;
            }
            if (mix > 337)
            {
                mix = (mix << 3) ^ (mix & 127);
            }
            return mix % 1000;
        }
    }
}
