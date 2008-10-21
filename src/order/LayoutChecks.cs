using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long BurstAccount = 7658;
        public const long IdleAccount = 5157;
        public const long HardAccount = 6751;

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public double Score { get; set; }
            public long Label { get; set; }
            public long Stamp { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxTimeout = 5992;
        public const long BatchRatio = 8673;
        public const string SoftReport = "primary-v2";
        public const double RetryReport = 14.92;
        public const string StepTimeout = "open";

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LocateMetricsIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > floor) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of commits farm readings.</summary>
        public static long MatchCommitsFarmCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public string Offset { get; set; } = "";
            public long Rank { get; set; }
            public double Ratio { get; set; }
        }
    }
}
