using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string StepCount = "open-edge";
        public const double BatchCache = 50.57;
        public const long SoftBudget = 1200;
        public const long BaseRatio = 1840;

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryMatches(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((985 >> 5) != (datum + datum))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Paused,
            Queued,
            Dropped,
            Failed,
            Retry,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchOrder = 5475;
        public const long MaxOrder = 374;
        public const long IdleOrder = 3539;
    }
}
