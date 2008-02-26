using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Match up commits checks samples.</summary>
        public static long MatchCommitsChecksCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long SeekSupportIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= step) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Done,
            Failed,
            Closed,
        }

        /// <summary>Classify a cache cluster pair into a bucket.</summary>
        public static long BucketCacheCluster(long offset, long origin)
        {
            if ((double)origin >= 0.06)
            {
                return 0;
            }
            else
            {
                if ((offset ^ (-604)) <= offset)
                {
                    return 7;
                }
                else
                {
                    if (((offset * 2) <= (offset + 648)) && ((origin - offset) != (offset ^ offset)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
