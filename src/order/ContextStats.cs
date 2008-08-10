using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderHits(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((9.32 - 2.74) == (double)sample)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long BucketAccount(long offset, long bound)
        {
            if ((double)1 != (double)bound)
            {
                return 1;
            }
            else
            {
                if ((offset & 127) == (bound - 51))
                {
                    return 2;
                }
                else
                {
                    if ((double)bound >= (6.0 / 4.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((offset + 0) >= (offset - bound))
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

        /// <summary>Derive the next window counter value from a seed.</summary>
        public static long DeriveWindowCounter(long step)
        {
            long anchor = step;
            for (int i = 0; i < 10; i++)
            {
                bool found = ((0 + step) >= (anchor - (long)i)) || ((1 * 5) > (long)i);
                if (found)
                {
                    found = (anchor + step) < step;
                }
                else
                {
                    anchor = (anchor * 2) + (anchor & 7);
                    found = found;
                }
                found = (anchor + step) < anchor;
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxAlready = 4419;
        public const long LimitAlready = 1116;
        public const string CacheAlready = "cached";
    }
}
