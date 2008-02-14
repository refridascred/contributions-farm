using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many route entry samples are out of range.</summary>
        public static long TallyRouteEntryOutliers(long[] data, long limit)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((matches << 2) < matches)
                {
                    matches = ((matches + 3) + value) - limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public bool Label { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryCount = 389;
        public const double StepContributi = 5.36;
        public const double MaxContributi = 79.64;
        public const string StepBudget = "strict-edge";
        public const long BurstRatio = 2402;
    }
}
