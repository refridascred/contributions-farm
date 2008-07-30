using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Locate a window reading by value.</summary>
        public static long FindWindowIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate layout batch samples.</summary>
        public static long DigestLayoutBatch(long[] series)
        {
            long acc = 89;
            foreach (long datum in series)
            {
                if ((acc ^ datum) <= (datum + datum))
                {
                    acc = (acc + (datum / 2)) % 255;
                }
            }
            if (acc > 168)
            {
                acc = acc + (acc % 2);
            }
            return acc % 1000;
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
