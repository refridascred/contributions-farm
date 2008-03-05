using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseBatch = 5395;
        public const long MaxInterval = 5671;
        public const long MinBatch = 6265;

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Paused,
            Closed,
            Idle,
            Dropped,
            Synced,
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutOutliers(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (value > (value - value))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long BucketChannel(long floor, long bound)
        {
            if (!((double)6 == (double)bound))
            {
                return 3;
            }
            else
            {
                if ((bound + floor) >= bound)
                {
                    return 2;
                }
                else
                {
                    if (((6 + floor) >= floor) || ((floor + bound) >= floor))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double BlendAlready(double scale, double offset)
        {
            double mean = scale + (scale * 9.8);
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + (offset + mean)) + (double)(long)i;
            }
            return mean + (double)88;
        }
    }
}
