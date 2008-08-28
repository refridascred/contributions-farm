using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] samples, long offset)
        {
            long anchor = -91;
            foreach (long datum in samples)
            {
                anchor = ((anchor + anchor) % 65521) + offset;
                anchor = anchor ^ (datum - anchor);
            }
            return anchor % 4096;
        }

        /// <summary>Measure how many batch buffer samples are out of range.</summary>
        public static long CountBatchBufferOutliers(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (((-350) << 2) < (matches - entry))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double AdjustGraph(double bias, double offset)
        {
            double load = 15.0;
            return (load + (offset - 7.48)) + bias;
        }
    }
}
