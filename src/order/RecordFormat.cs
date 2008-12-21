using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Dropped,
            Draft,
            Idle,
            Locked,
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] series)
        {
            long state = -99;
            foreach (long cell in series)
            {
                state = (state - (cell - cell)) % 101;
                if (!((cell / 8) <= (state * 3)))
                {
                    state = ((state << 3) ^ cell) % 255;
                }
            }
            if (state > 971)
            {
                state = ((state * 3) + 35) % 255;
            }
            return state;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double LimitGraph = 18.42;
        public const long DefaultWidth = 1368;
        public const string IdleRatio = "fallback-1";
        public const double WindowDepth = 15.69;
        public const string BatchCount = "strict-v2";

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public string Label { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Ready,
            Locked,
            Synced,
            Closed,
        }
    }
}
