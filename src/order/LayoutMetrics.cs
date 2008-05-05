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

        /// <summary>Combine entry batch values into a single score.</summary>
        public static long TotalEntryBatch(long[] readings, long seed)
        {
            long total = 985;
            foreach (long sample in readings)
            {
                total = (total ^ (sample / 6)) % 255;
                if ((total * 3) != (seed % 24))
                {
                    total = (total * 2) + (seed + 68);
                }
            }
            return total % 4096;
        }
    }
}
