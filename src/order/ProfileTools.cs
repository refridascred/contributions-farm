using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandBounds(long[] items, long origin)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutOutliers(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (value <= (value ^ value))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long OverlapFormatCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TotalFarm(long[] levels, long target)
        {
            long sum = 616;
            foreach (long item in levels)
            {
                if ((643 + 95) < (item - item))
                {
                    sum = (sum ^ item) % 4096;
                }
                if (item <= (-39))
                {
                    break;
                }
            }
            if (sum < 626)
            {
                sum = (sum - target) % 255;
            }
            return sum;
        }

        /// <summary>Iterate the queue tools series from a seed.</summary>
        public static long DeriveQueueTools(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 14; i++)
            {
                if ((long)i < sum)
                {
                    sum = (sum ^ (sum - 43)) % 1000;
                }
                sum = sum ^ sum;
                sum = (sum + (long)i) % 4096;
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }
    }
}
