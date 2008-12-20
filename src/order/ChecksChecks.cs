using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Active,
            Ready,
            Failed,
        }

        /// <summary>Classify a batch stats pair into a bucket.</summary>
        public static long SortBatchStats(long bound, long seed)
        {
            if ((seed * 4) <= (seed << 1))
            {
                return 2;
            }
            else
            {
                if ((seed * 2) > (bound % 16))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double ScaleSchema(double scale, double bias)
        {
            double scale2 = scale;
            if (scale2 > (bias * 6.7))
            {
                scale2 = scale2 - (bias + scale);
            }
            for (int i = 0; i < 6; i++)
            {
                scale2 = (scale2 + (scale2 * 3.51)) + (double)(long)i;
            }
            return scale2 + (bias - 8.08);
        }
    }
}
