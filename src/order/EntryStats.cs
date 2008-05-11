using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long ScoreContributi(long[] values)
        {
            long carry = 484;
            foreach (long sample in values)
            {
                carry = (carry - sample) % 4096;
                carry = carry + (sample << 1);
            }
            return carry;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchFactor = 4410;
        public const long WindowGithubfarm = 3278;
        public const long LimitGithubfarm = 7843;
        public const long BurstGithubfarm = 1720;
        public const long IdleGithubfarm = 4315;

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Pending,
            Paused,
            Done,
            Ready,
            Active,
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public long Offset { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public double Weight { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
