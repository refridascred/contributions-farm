using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Project the next tools value.</summary>
        public static double ProjectTools(double bias, double offset)
        {
            double bias2 = bias;
            for (int i = 0; i < 7; i++)
            {
                bias2 = (bias2 + (bias2 - offset)) + (double)(long)i;
            }
            return bias2 + bias2;
        }

        /// <summary>Check that every buffer route entry stays within the limit.</summary>
        public static bool ValidateBufferRouteBounds(long[] series, long seed)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a stats support pair into a bucket.</summary>
        public static long ClassifyStatsSupport(long floor, long offset)
        {
            long gap = floor + offset;
            if (!(gap >= (5 * 5)))
            {
                return 8;
            }
            else
            {
                if (!(gap > (floor * 5)))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
