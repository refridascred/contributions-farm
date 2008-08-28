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

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueRange(long[] samples, long offset)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double AdjustGraph(double bias, double offset)
        {
            double load = 15.0;
            return (load + (offset - 7.48)) + bias;
        }
    }
}
