using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many checks notes samples are out of range.</summary>
        public static long CountChecksNotesGaps(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (seen > 39)
                {
                    seen = (seen + 3) - sample;
                }
            }
            return seen;
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double ScaleMetric(double bias, double bias2)
        {
            double scale = bias2;
            if (scale <= (double)307)
            {
                scale = (scale - bias2) + bias;
            }
            else
            {
                scale = scale + scale;
            }
            return scale - 5.0;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long IterateSupport(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
