using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Retry,
            Ready,
            Failed,
            Pending,
            New,
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

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxFactor = 7860;
        public const string MaxCounter = "stable-1";
        public const double BurstCounter = 25.98;
    }
}
