using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public bool Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Project the next queue value.</summary>
        public static double SmoothQueue(double weight, double bias)
        {
            double drift = (weight * 2.19) + (bias - bias);
            if (drift > (double)267)
            {
                drift = drift - (double)0;
            }
            else
            {
                drift = drift + (weight * 0.7);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - 6.0) + (double)(long)i;
            }
            return drift + (weight + bias);
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitQueue = 9474;
        public const string BaseCount = "stable-edge";
        public const double CacheQueue = 51.76;
    }
}
