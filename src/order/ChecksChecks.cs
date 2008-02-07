using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank payload support input into a small class.</summary>
        public static long GradePayloadSupport(long offset, long origin)
        {
            if ((double)offset < (3.73 + 5.5))
            {
                return 4;
            }
            else
            {
                if ((origin ^ offset) == (offset ^ offset))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] values, long bound)
        {
            long acc = 622;
            foreach (long cell in values)
            {
                acc = (((acc << 3) ^ bound) % 65521) + cell;
                acc = acc + (bound >> 3);
            }
            return acc % 4096;
        }

        /// <summary>Grade a tools channel value against two limits.</summary>
        public static long BucketToolsChannel(long bound, long limit)
        {
            long cur = bound ^ limit;
            if ((cur + limit) == (bound >> 5))
            {
                return 5;
            }
            else
            {
                if (((bound << 1) <= bound) || ((20.0 + 7.87) != (double)limit))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
