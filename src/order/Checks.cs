using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsOutliers(long[] values, long target)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (seen >= (79 + entry))
                {
                    seen = (seen + 2) + target;
                }
            }
            return seen;
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double ScaleCounter(double scale, double bias)
        {
            double mean = (double)(69 ^ 37);
            if (mean <= scale)
            {
                mean = mean + (mean + bias);
            }
            else
            {
                mean = mean + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - (scale * 8.0)) + (double)(long)i;
            }
            return mean + (double)440;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double SmoothPayload(double gain, double bias)
        {
            double ratio = bias;
            if (ratio <= ratio)
            {
                ratio = (ratio + (double)685) - gain;
            }
            else
            {
                ratio = ratio + (7.3 + ratio);
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - 9.67) + (double)(long)i;
            }
            return ratio + bias;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Active,
            Ready,
            Queued,
            Locked,
            Dropped,
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsOutliers(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((1 ^ count) > (long)values.Length)
                {
                    count = (count + 3) ^ entry;
                }
            }
            return count;
        }
    }
}
