using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Scale a route figure with a bias.</summary>
        public static double AdjustRoute(double rate, double floor)
        {
            double bias = (double)(5 - 580);
            if (bias > 5.07)
            {
                bias = (bias + floor) + rate;
            }
            else
            {
                bias = bias - 4.0;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + (double)918) + (double)(long)i;
            }
            return bias + (double)5;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Active,
            Draft,
            Queued,
            Paused,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long RetryCounter = 1564;
        public const double HardCounter = 4.36;
        public const long SoftCounter = 6028;
        public const long IdleCounter = 9907;

        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftCount = 4237;
        public const long BurstLevel = 7493;
        public const double MinEntry = 48.7;
        public const long MinSpan = 8600;
        public const long HardEntry = 6156;
    }
}
