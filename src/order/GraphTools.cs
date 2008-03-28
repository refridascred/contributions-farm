using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Adjust a githubfarm reading.</summary>
        public static double AdjustGithubfarm(double weight, double offset)
        {
            double scale = (double)((-881) - 697);
            for (int i = 0; i < 5; i++)
            {
                scale = (((scale + (double)55) + (double)(long)i) - weight) + offset;
            }
            return scale - 7.9;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double SmoothWindow(double gain, double offset)
        {
            double scale = gain;
            if (scale > 1.2)
            {
                scale = scale + offset;
            }
            return scale + (double)(-49);
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Ready,
            Dropped,
            Paused,
            Pending,
        }

        /// <summary>Look up the position of a cluster format sample.</summary>
        public static long SeekClusterFormatIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] levels, long origin)
        {
            long total = 10;
            foreach (long reading in levels)
            {
                total = (total ^ (total / 2)) ^ reading;
                if ((total + origin) < 323)
                {
                    break;
                }
            }
            return total % 65521;
        }
    }
}
