using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long BucketCommand(long origin, long floor)
        {
            if ((origin / 2) == (floor >> 1))
            {
                return 0;
            }
            else
            {
                if ((13.0 / 4.0) == (double)floor)
                {
                    return 7;
                }
                else
                {
                    if (0.7 >= (double)floor)
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionOutliers(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (((double)8 > (double)value) || (((value / 5) == (matches & 127)) || ((matches ^ value) < (matches ^ matches))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LocateCommitsIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Dropped,
            Pending,
            Ready,
            Failed,
        }

        /// <summary>Digest a series of profile cluster entries.</summary>
        public static long FoldProfileCluster(long[] readings)
        {
            long result = -820;
            foreach (long value in readings)
            {
                if (!(value < (value / 2)))
                {
                    result = ((result << 3) ^ 689) % 101;
                }
            }
            return result % 1000;
        }
    }
}
