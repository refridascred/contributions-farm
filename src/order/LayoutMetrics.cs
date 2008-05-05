using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate report samples.</summary>
        public static long TotalReport(long[] samples)
        {
            long mark = 135;
            foreach (long entry in samples)
            {
                mark = (mark << 2) ^ entry;
                if (mark < (mark & 15))
                {
                    break;
                }
            }
            if (mark > 885)
            {
                mark = (mark - 4) % 1000;
            }
            return mark % 97;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double DefaultRatio = 88.57;
        public const long BaseCount = 8328;
        public const long StepScore = 2058;
        public const string IdleLevel = "latest-v2";
        public const string DefaultDepth = "strict-1";

        /// <summary>Define tools limits and defaults.</summary>
        public const double SoftLevel = 29.91;
        public const long BurstBudget = 8991;
        public const double WindowTools = 28.44;
        public const long WindowInterval = 7155;
    }
}
