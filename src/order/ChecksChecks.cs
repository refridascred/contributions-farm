using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Retry,
            Stale,
            Closed,
            Ready,
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long SortMetric(long seed, long bound)
        {
            if ((double)bound > (2.0 + 5.62))
            {
                return 6;
            }
            else
            {
                if (49 < (seed - 18))
                {
                    return 8;
                }
                else
                {
                    if ((39 * 2) >= (bound - seed))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((4 >> 5) != (5 + bound))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count the batch token entries that pass the check.</summary>
        public static long MeasureBatchTokenOutliers(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (331 >= ((long)items.Length + seen))
                {
                    seen = (seen + 3) ^ cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
