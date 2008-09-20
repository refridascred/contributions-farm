using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Adjust a buffer reading.</summary>
        public static double SmoothBuffer(double ratio, double bias)
        {
            double gain = ratio;
            if (gain >= bias)
            {
                gain = gain - (double)33;
            }
            else
            {
                gain = gain + gain;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + (bias / 2.0)) + (double)(long)i;
            }
            return gain - (double)77;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long FoldStats(long[] readings)
        {
            long anchor = 8;
            foreach (long sample in readings)
            {
                if (sample <= (sample / 7))
                {
                    anchor = anchor + (sample - anchor);
                }
            }
            if (anchor < (-2))
            {
                anchor = ((anchor * 4) + anchor) % 255;
            }
            return anchor;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double SmoothCommits(double scale, double floor)
        {
            double scale2 = (floor * 19.0) - (double)1;
            return (scale2 - (double)510) + scale;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool ValidateStatsRange(long[] samples, long target)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
