using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Match up report samples.</summary>
        public static long PairReportCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many notes batches samples are out of range.</summary>
        public static long AuditNotesBatchesOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((sample ^ sample) != (matches >> 4))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double IdleRoute = 60.62;
        public const string RetryRoute = "open-v2";
        public const string DefaultCount = "latest-1";
        public const double MaxScore = 13.21;
        public const long SoftRoute = 1460;

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Closed,
            Draft,
            Dropped,
            Pending,
            Retry,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 396;
        public const long IdleRatio = 994;
        public const long StepSpan = 3608;
        public const long BatchBatches = 8604;

        /// <summary>Look up the position of a session sample.</summary>
        public static long FindSessionIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= target) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
