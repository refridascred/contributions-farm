using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a channel stats value against two limits.</summary>
        public static long GradeChannelStats(long seed, long origin)
        {
            long offset = seed ^ origin;
            if ((double)seed >= (13.0 - 9.2))
            {
                return 0;
            }
            else
            {
                if (origin < (seed << 3))
                {
                    return 3;
                }
                else
                {
                    if ((8.65 + 1.06) < (double)offset)
                    {
                        return 6;
                    }
                    else
                    {
                        if (origin < (151 & 127))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Locked,
            Retry,
            Queued,
        }

        /// <summary>Digest a series of record route entries.</summary>
        public static long ScoreRecordRoute(long[] readings, long limit)
        {
            long total = 36;
            foreach (long value in readings)
            {
                if (!((value - 80) > (value << 3)))
                {
                    total = (total ^ (total + limit)) % 101;
                }
                if (total < (limit >> 4))
                {
                    total = total - total;
                }
            }
            return total % 97;
        }
    }
}
