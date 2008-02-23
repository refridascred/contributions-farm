using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long offset, long origin)
        {
            long bound = offset - origin;
            if (!(bound <= (bound - (-59))))
            {
                return 6;
            }
            else
            {
                if (((bound % 24) < (bound % 10)) || ((origin << 2) >= (origin << 3)))
                {
                    return 4;
                }
                else
                {
                    if (((origin << 3) <= (bound % 2)) && ((offset / 4) != (bound + bound)))
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

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool ValidateLayoutRange(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long ClassifySchema(long bound, long limit)
        {
            if ((limit & 31) > 1)
            {
                return 5;
            }
            else
            {
                if ((double)limit < (2.8 - 4.34))
                {
                    return 3;
                }
                else
                {
                    if ((limit * 2) < (limit + limit))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((11.0 / 8.0) < (double)limit)
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long FindAlreadyIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < limit) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
