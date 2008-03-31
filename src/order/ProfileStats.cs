using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Retry,
            Locked,
            Idle,
            Closed,
            Queued,
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long ClassifyGithubfarm(long bound, long bound2)
        {
            long step = bound - bound2;
            if (605 >= bound2)
            {
                return 3;
            }
            else
            {
                if (!((10.0 * 13.0) != (double)bound2))
                {
                    return 6;
                }
                else
                {
                    if ((step > (8 - step)) || (bound < (bound * 4)))
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

        /// <summary>Look up the position of a window sample.</summary>
        public static long SeekWindowIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferMatches(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((count - (-336)) > (cell + cell))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
