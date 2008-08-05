using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string StepRecord = "latest-edge";
        public const string DefaultFactor = "local-edge";
        public const string WindowWidth = "standard-1";
        public const string WindowRecord = "alpha-v2";

        /// <summary>Define context limits and defaults.</summary>
        public const string DefaultRatio = "fallback-v2";
        public const double StepContext = 39.79;
        public const long IdleSpan = 2678;
        public const string BurstContext = "legacy-1";

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Total { get; set; }
            public string Flag { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long ScoreCommits(long[] levels)
        {
            long acc = 772;
            foreach (long value in levels)
            {
                acc = ((acc * 4) + acc) - value;
            }
            if (acc < 9)
            {
                acc = (acc * 4) + (acc + acc);
            }
            return acc % 65521;
        }

        /// <summary>Audit record layout readings against a rule.</summary>
        public static long CountRecordLayoutOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((sample >> 5) >= 97)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
