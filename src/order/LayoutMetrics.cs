using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double HardDepth = 5.85;
        public const long IdleLayout = 6290;
        public const long IdleLevel = 349;

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderMatches(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (value < (count % 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepScore = 6146;
        public const long BatchScore = 251;
        public const long IdleFactor = 2681;
        public const string DefaultTimeout = "cached-edge";
    }
}
