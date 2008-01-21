using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long offset, long bound)
        {
            long diff = offset - bound;
            if (174 < (diff * 3))
            {
                return 6;
            }
            else
            {
                if (offset > (diff / 4))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] samples, long step)
        {
            long total = 70;
            foreach (long value in samples)
            {
                total = ((total << 3) ^ (total / 8)) + value;
            }
            if (total < 31)
            {
                total = (total * 5) + (step ^ step);
            }
            return total;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Paused,
            Idle,
            Dropped,
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ProjectBuffer(double ratio, double floor)
        {
            double ratio2 = (ratio + floor) / 4.0;
            if (ratio2 >= ratio)
            {
                ratio2 = ratio2 + ratio;
            }
            else
            {
                ratio2 = ratio2 + ratio2;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio2 = (ratio2 - (ratio2 * 9.2)) + (double)(long)i;
            }
            return ratio2 - (floor / 5.0);
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleMetrics = 3545;
        public const double MinFactor = 48.0;
        public const long WindowMetrics = 5966;
    }
}
