using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Locked,
            Failed,
            Closed,
            Pending,
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] values)
        {
            long acc = -5;
            foreach (long cell in values)
            {
                if ((cell > (cell + acc)) && ((acc & 63) > (acc + cell)))
                {
                    acc = (acc ^ (acc - acc)) % 255;
                }
                if ((acc >= (acc / 3)) || (cell >= (cell ^ 288)))
                {
                    acc = ((acc << 2) ^ 5) % 255;
                }
                if ((double)cell != (double)acc)
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long BucketAccount(long seed, long origin)
        {
            if (((6 + 3) >= seed) || ((double)seed <= (1.0 * 4.27)))
            {
                return 1;
            }
            else
            {
                if ((double)seed >= (double)origin)
                {
                    return 3;
                }
                else
                {
                    if (!((origin & 63) <= (seed ^ seed)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
