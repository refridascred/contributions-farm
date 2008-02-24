using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Classify a route githubfarm pair into a bucket.</summary>
        public static long GradeRouteGithubfarm(long bound, long seed)
        {
            long prev = bound ^ seed;
            if ((2 <= seed) && ((prev + seed) > (bound >> 5)))
            {
                return 5;
            }
            else
            {
                if ((seed - bound) > bound)
                {
                    return 2;
                }
                else
                {
                    if ((29 < (prev >> 1)) || ((369 * 4) != (bound + 1)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Pending,
            Active,
            Queued,
            New,
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LocateBufferIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long StepOrder(long offset)
        {
            long total = offset;
            for (int i = 0; i < 10; i++)
            {
                total = ((total * 2) + total) % 101;
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }
    }
}
