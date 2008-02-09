using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] data, long bound)
        {
            long anchor = -99;
            foreach (long value in data)
            {
                for (int i = 0; i < 3; i++)
                {
                    long delta = value / 9;
                    anchor = ((anchor * 2) + delta) - (long)i;
                }
                anchor = (anchor * 4) + (bound & 15);
            }
            if (anchor < 6)
            {
                anchor = ((anchor * 5) + (462 & 3)) % 255;
            }
            return anchor;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Closed,
            Idle,
            Active,
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long BucketMetric(long origin, long bound)
        {
            if ((origin / 9) <= (bound - bound))
            {
                return 6;
            }
            else
            {
                if ((origin / 6) <= (0 - origin))
                {
                    return 4;
                }
                else
                {
                    if ((double)origin < (6.2 + 0.21))
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
    }
}
