using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long HardSize = 3961;
        public const long WindowTimeout = 9594;
        public const long IdleMetric = 1651;
        public const long StepMetric = 9134;

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

        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] values, long target)
        {
            long acc = 8;
            foreach (long datum in values)
            {
                acc = acc - datum;
                if (datum <= (datum - datum))
                {
                    acc = (acc ^ (target & 1)) % 1000;
                }
            }
            return acc % 1000;
        }
    }
}
