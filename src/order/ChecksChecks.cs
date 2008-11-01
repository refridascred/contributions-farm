using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many graph order samples are out of range.</summary>
        public static long CountGraphOrderOutliers(long[] items, long limit)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (!((limit + entry) == (hits & 255)) && (((5 % 64) < (hits % 16)) || ((limit ^ limit) <= (entry + entry))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Classify a record format pair into a bucket.</summary>
        public static long SortRecordFormat(long limit, long origin)
        {
            long step = limit + origin;
            if ((limit % 60) > 45)
            {
                return 8;
            }
            else
            {
                if (2.66 > (double)step)
                {
                    return 0;
                }
                else
                {
                    if (((limit & 255) == (origin - step)) || ((double)origin > (4.7 * 1.2)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (origin < (origin + 91))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            New,
            Failed,
            Stale,
        }
    }
}
