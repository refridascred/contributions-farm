using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadOutliers(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((double)matches > (6.72 + 12.0))
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public string Rank { get; set; } = "";
            public bool Weight { get; set; }
            public long Limit { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Match up metrics samples.</summary>
        public static long MatchMetricsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double MaxScore = 45.7;
        public const long StepCount = 9468;
        public const string CacheRatio = "local-1";
        public const long WindowDepth = 4552;

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Failed,
            Paused,
            Done,
            New,
        }
    }
}
