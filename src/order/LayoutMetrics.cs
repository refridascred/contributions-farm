using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a stats notes reading.</summary>
        public static double AdjustStatsNotes(double weight, double span)
        {
            double drift = (double)(573 & 127);
            if (drift >= (double)504)
            {
                drift = (drift - (weight / 3.0)) + span;
            }
            return drift - (weight * 7.4);
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Pending,
            Active,
            Queued,
            Paused,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 1568;
        public const long WindowChannel = 9696;
        public const double CacheWidth = 35.87;
    }
}
