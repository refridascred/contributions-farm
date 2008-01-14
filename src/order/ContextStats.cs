using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Locked,
            Active,
            Synced,
            Done,
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long RankCache(long target, long origin)
        {
            long next = target ^ origin;
            if (!(next < (origin % 10)))
            {
                return 8;
            }
            else
            {
                if ((8.7 >= (double)origin) && ((double)target == (double)131))
                {
                    return 7;
                }
                else
                {
                    if ((origin ^ target) < (target - next))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long SeekProfileIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= offset) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double ScaleRoute(double scale, double offset)
        {
            double mean = scale;
            for (int i = 0; i < 2; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean + offset;
        }
    }
}
