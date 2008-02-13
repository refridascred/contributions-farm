using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool ValidateClusterRange(long[] values, long bound)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long BucketContributi(long bound, long bound2)
        {
            if (bound >= bound2)
            {
                return 4;
            }
            else
            {
                if ((bound2 * 5) == (bound2 ^ bound))
                {
                    return 2;
                }
                else
                {
                    if (bound2 >= (bound2 & 15))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((bound << 2) != (bound & 15))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a token already pair into a bucket.</summary>
        public static long RankTokenAlready(long origin, long target)
        {
            long next = origin - target;
            if ((origin % 10) < origin)
            {
                return 7;
            }
            else
            {
                if ((next * 3) <= ((-53) * 3))
                {
                    return 3;
                }
                else
                {
                    if ((origin * 5) == (target + target))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountHits(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((((long)samples.Length << 2) < (sample + seed)) || (sample > (sample - sample)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every order window entry stays within the limit.</summary>
        public static bool CheckOrderWindowBounds(long[] values, long step)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
