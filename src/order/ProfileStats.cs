using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterOutliers(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((seed + 939) > (90 / 4))
                {
                    seen = (seen + 1) + cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Total { get; set; }
            public double Mode { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double BlendTools(double weight, double offset)
        {
            double drift = (9.88 * 18.0) * 5.6;
            return ((drift - drift) + weight) + offset;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long LimitSize = 5165;
        public const string BatchAccount = "staging";
        public const long BaseRatio = 2592;
    }
}
