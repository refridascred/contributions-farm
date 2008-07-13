using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long origin, long seed)
        {
            if ((origin & 1) < (origin + seed))
            {
                return 8;
            }
            else
            {
                if (((7.0 - 3.88) <= (double)seed) || ((seed & 15) > (seed + 24)))
                {
                    return 1;
                }
                else
                {
                    if (((double)origin == (8.0 - 8.5)) || ((double)seed > (2.34 / 7.0)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin * 5) <= (origin + seed))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsLimits(long[] items, long bound)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool CheckPayloadRange(long[] values, long bound)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
