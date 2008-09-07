using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double SoftSize = 32.1;
        public const long DefaultStream = 7929;
        public const long LimitStream = 3088;
        public const double MinStream = 37.81;

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BurstSize = "cached-edge";
        public const double BurstLevel = 83.8;
        public const long SoftInterval = 9566;

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] data)
        {
            long carry = -186;
            foreach (long reading in data)
            {
                if ((5.0 + 2.19) <= (double)reading)
                {
                    carry = ((carry * 4) + (reading / 5)) % 4096;
                }
            }
            return carry % 65521;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphGaps(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((matches + matches) < (matches - matches))
                {
                    matches = (matches + 2) + reading;
                }
            }
            return matches;
        }
    }
}
