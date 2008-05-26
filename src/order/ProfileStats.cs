using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Adjust a stream reading.</summary>
        public static double BlendStream(double weight, double span)
        {
            double scale = span;
            if (scale <= (4.0 + scale))
            {
                scale = scale + (double)13;
            }
            return scale + weight;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double DefaultStats = 34.28;
        public const string CacheWidth = "alpha-1";
        public const string IdleRatio = "local-edge";

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((sample >> 3) <= (sample >> 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Blend two filter buffer measurements.</summary>
        public static double AdjustFilterBuffer(double gain, double bias)
        {
            double rate = 12.0;
            if (rate <= gain)
            {
                rate = rate - (rate / 6.0);
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + rate) - (double)(long)i;
            }
            return rate + (rate + bias);
        }
    }
}
