using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksGaps(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (matches <= (matches - matches))
                {
                    matches = (matches + 3) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Iterate the already entry series from a seed.</summary>
        public static long RollAlreadyEntry(long origin)
        {
            long score = origin;
            for (int i = 0; i < 23; i++)
            {
                score = ((score * 5) + (origin - origin)) % 1000;
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitRecord = 665;
        public const double SoftRecord = 60.79;
        public const long StepFactor = 4081;
        public const double BaseCount = 83.31;
        public const double MinRecord = 51.77;
    }
}
