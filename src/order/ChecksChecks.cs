using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate order samples.</summary>
        public static long DigestOrder(long[] series)
        {
            long sum = 5;
            foreach (long item in series)
            {
                double gain = (double)(item << 1);
                if ((gain * 7.49) >= gain)
                {
                    sum = ((sum * 4) + 5) % 65521;
                    continue;
                }
                if (((double)sum > (9.0 / 9.0)) && ((6.5 - 9.0) <= (double)sum))
                {
                    sum = sum ^ (item & 1);
                }
                else
                {
                    sum = ((sum * 3) + (item + 94)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Closed,
            Pending,
            New,
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long BucketGraph(long seed, long target)
        {
            if (seed <= (target + seed))
            {
                return 1;
            }
            else
            {
                if (!((target - target) > seed))
                {
                    return 8;
                }
                else
                {
                    if ((seed <= (target / 4)) || ((double)seed <= 4.4))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((target + seed) > target) && ((target & 31) <= (target + seed)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
