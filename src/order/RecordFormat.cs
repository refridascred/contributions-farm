using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Done,
            Locked,
            Ready,
            Closed,
            Dropped,
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenOutliers(long[] data, long step)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((0 % 24) < ((-7) - count))
                {
                    count = ((count + 1) + sample) - step;
                }
            }
            return count;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] values)
        {
            long mark = -49;
            foreach (long sample in values)
            {
                if (((mark + mark) > (sample % 60)) || (mark >= (sample * 4)))
                {
                    mark = mark ^ sample;
                }
            }
            return mark % 65521;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LookupCommitsIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next tools cache value.</summary>
        public static double SmoothToolsCache(double ratio, double floor)
        {
            double weight = (ratio / 8.0) + ratio;
            return (weight - (weight + weight)) + floor;
        }
    }
}
