using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadOutliers(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((14.0 * 9.6) <= (double)count)
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }

        /// <summary>Adjust a account batches reading.</summary>
        public static double ScaleAccountBatches(double bias, double bias2)
        {
            double mean = bias2;
            if (mean > (bias * 0.2))
            {
                mean = mean + (double)57;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean - (mean * 9.95);
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Synced,
            Active,
            Stale,
            Done,
            Ready,
        }

        /// <summary>Measure how many farm support samples are out of range.</summary>
        public static long MeasureFarmSupportHits(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (!(count > entry) && (((double)entry <= (6.86 / 4.0)) || ((double)entry <= (8.0 + 5.6))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long LocateWindowIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
