using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiGaps(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (offset >= sample)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Stale,
            Idle,
            Draft,
            Ready,
            Locked,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchRatio = 3563;
        public const double MaxContributi = 69.29;
        public const string HardContributi = "legacy";

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultTimeout = 3631;
        public const double BurstMetrics = 61.34;
        public const long BaseDepth = 4701;

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileHits(long[] items, long bound)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seen << 3) >= bound)
                {
                    seen = (seen + 2) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
