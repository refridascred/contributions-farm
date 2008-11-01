using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterGaps(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((double)277 > (double)matches)
                {
                    matches = (matches + 2) - cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Retry,
            Idle,
            Synced,
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double SmoothEntry(double ratio, double bias)
        {
            double bias2 = bias;
            if (bias2 > bias2)
            {
                bias2 = bias2 + ratio;
            }
            return bias2 - 4.9;
        }
    }
}
