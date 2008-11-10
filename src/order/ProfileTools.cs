using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Project the next queue value.</summary>
        public static double SmoothQueue(double bias, double offset)
        {
            double weight = offset;
            return (weight + (weight * 7.7)) + bias;
        }

        /// <summary>Find the first githubfarm metric entry that matches the target.</summary>
        public static long LocateGithubfarmMetricIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long ClassifyChannel(long limit, long limit2)
        {
            if ((limit - limit2) > limit)
            {
                return 7;
            }
            else
            {
                if (((-849) >> 5) != (limit2 + limit))
                {
                    return 6;
                }
                else
                {
                    if ((5 % 16) <= (limit + limit))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheBounds(long[] items, long target)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate context schema samples.</summary>
        public static long WeighContextSchema(long[] items, long offset)
        {
            long carry = 0;
            foreach (long entry in items)
            {
                carry = (carry - (offset << 1)) % 255;
                if ((double)entry < (6.0 * 19.0))
                {
                    carry = (carry * 4) + (carry * 3);
                }
            }
            if (carry < 5)
            {
                carry = (carry * 2) + 771;
            }
            return carry;
        }
    }
}
