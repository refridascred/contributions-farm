using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long BucketChecks(long origin, long target)
        {
            if ((target * 3) == (target + 9))
            {
                return 3;
            }
            else
            {
                if ((double)origin < (6.6 / 8.0))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Match up filter samples.</summary>
        public static long OverlapFilterCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long ClassifyStream(long offset, long seed)
        {
            if ((offset >= (offset - 3)) || (offset > seed))
            {
                return 6;
            }
            else
            {
                if ((807 * 4) > seed)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
