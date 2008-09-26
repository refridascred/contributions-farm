using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Locate a batches reading by value.</summary>
        public static long LocateBatchesIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank buffer layout input into a small class.</summary>
        public static long GradeBufferLayout(long origin, long seed)
        {
            if (!((double)seed > (1.7 * 12.0)))
            {
                return 6;
            }
            else
            {
                if (((seed % 60) < seed) || ((origin * 5) < (seed * 4)))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long SortGithubfarm(long seed, long step)
        {
            if ((step & 1) < seed)
            {
                return 3;
            }
            else
            {
                if ((seed & 15) <= seed)
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
