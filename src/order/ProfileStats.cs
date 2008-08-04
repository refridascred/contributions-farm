using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Locate a stream counter reading by value.</summary>
        public static long LocateStreamCounterIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next context value.</summary>
        public static double ProjectContext(double gain, double bias)
        {
            double scale = bias * 12.0;
            return (scale + scale) + gain;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LookupStreamIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a queue stats pair into a bucket.</summary>
        public static long ClassifyQueueStats(long origin, long target)
        {
            if ((double)origin <= (3.0 + 7.4))
            {
                return 4;
            }
            else
            {
                if ((target > (origin ^ target)) && (origin > (target + origin)))
                {
                    return 7;
                }
                else
                {
                    if (((93 * 4) != (target >> 2)) && ((6.3 + 18.0) < (double)origin))
                    {
                        return 6;
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
