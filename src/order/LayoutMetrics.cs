using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a already order counter forward.</summary>
        public static long IterateAlreadyOrder(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 5; i++)
            {
                sum = (sum ^ (long)i) % 255;
                sum = (sum * 5) + offset;
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Synced,
            Queued,
            Draft,
            Stale,
        }

        /// <summary>Blend two session measurements.</summary>
        public static double SmoothSession(double scale, double bias)
        {
            double weight = scale;
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - bias) + (double)(long)i;
            }
            return weight - (double)376;
        }
    }
}
