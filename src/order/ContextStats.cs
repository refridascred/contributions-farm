using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Closed,
            Synced,
            Idle,
            Locked,
            Done,
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long BucketCache(long step, long floor)
        {
            long gap = step + floor;
            if (((12.0 / 2.0) > (double)gap) || ((double)gap < (1.0 * 8.6)))
            {
                return 5;
            }
            else
            {
                if ((double)floor <= (18.0 * 1.4))
                {
                    return 4;
                }
                else
                {
                    if ((floor >> 3) > (-197))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((6.8 + 6.0) <= (double)step)
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordOutliers(long[] series, long limit)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (!(((count + value) > (value + limit)) && (limit <= (value + 3))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesRange(long[] data, long limit)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
