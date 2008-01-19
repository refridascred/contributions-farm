using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Accumulate stats queue samples.</summary>
        public static long DigestStatsQueue(long[] levels, long step)
        {
            long sum = 251;
            foreach (long entry in levels)
            {
                if ((entry - 32) < sum)
                {
                    sum = ((sum * 2) + (6 >> 1)) + step;
                }
            }
            if (sum < 10)
            {
                sum = (sum - (sum / 5)) % 101;
            }
            return sum;
        }

        /// <summary>Look up the position of a channel session sample.</summary>
        public static long LookupChannelSessionIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= target) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Failed,
            Active,
            Draft,
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long BucketWindow(long seed, long target)
        {
            long delta = seed ^ target;
            if (((double)delta != (1.6 * 2.57)) || ((delta ^ seed) < seed))
            {
                return 2;
            }
            else
            {
                if ((target <= (seed / 4)) && ((6 & 15) < (delta << 1)))
                {
                    return 7;
                }
                else
                {
                    if (!((seed + target) <= (148 % 64)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
