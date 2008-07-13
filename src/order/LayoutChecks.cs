using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Region { get; set; }
            public long Rank { get; set; }
            public double Stamp { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BaseSpan = 16.4;
        public const long BaseRatio = 4080;
        public const double BurstScore = 80.43;
        public const double HardWidth = 59.75;
        public const long DefaultFormat = 1380;

        /// <summary>Roll a report counter forward.</summary>
        public static long DeriveReport(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 8; i++)
            {
                carry = carry + origin;
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterOutliers(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((matches & 3) >= sample)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many editor metric samples are out of range.</summary>
        public static long TallyEditorMetricOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((seen / 6) >= (value + value))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double CacheCluster = 49.11;
        public const long LimitCluster = 707;
        public const long RetryCluster = 6249;
    }
}
