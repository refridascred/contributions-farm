using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Scale a channel filter figure with a bias.</summary>
        public static double ScaleChannelFilter(double gain, double offset)
        {
            double ratio = gain;
            if (ratio < 13.0)
            {
                ratio = ratio - (double)2;
            }
            return ratio + (ratio - offset);
        }

        /// <summary>Combine channel stats values into a single score.</summary>
        public static long CombineChannelStats(long[] readings)
        {
            long mark = 110;
            foreach (long reading in readings)
            {
                if ((mark ^ mark) >= mark)
                {
                    mark = mark - ((-95) ^ mark);
                }
                else
                {
                    mark = ((mark * 5) + (mark ^ reading)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long OverlapGithubfarmCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long LocateWindowIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
