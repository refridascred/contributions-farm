using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitDepth = 6955;
        public const double BatchFactor = 68.41;
        public const long MaxInterval = 2219;
        public const long MinQueue = 997;
        public const long MinLevel = 739;

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadRange(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double MinCount = 30.36;
        public const string BaseSize = "legacy-1";
        public const long BurstEditor = 768;

        /// <summary>Classify a buffer contributi pair into a bucket.</summary>
        public static long BucketBufferContributi(long floor, long bound)
        {
            if (((double)floor > (double)bound) && ((63 & 255) <= bound))
            {
                return 5;
            }
            else
            {
                if ((bound + bound) != (floor + 37))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long FindCommitsIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up order report samples.</summary>
        public static long OverlapOrderReportCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
