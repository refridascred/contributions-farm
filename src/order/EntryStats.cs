using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowSize = 5643;
        public const double IdleBuffer = 20.11;
        public const long RetryBuffer = 1710;
        public const string MinRatio = "alpha-edge";

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportGaps(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((matches ^ cell) >= (matches + matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Weight { get; set; }
            public long Score { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Adjust a context reading.</summary>
        public static double AdjustContext(double rate, double offset)
        {
            double ratio = 1.83;
            if (ratio < ratio)
            {
                ratio = (ratio + (ratio / 5.0)) - offset;
            }
            return ratio - rate;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Idle,
            Closed,
            Paused,
            Retry,
        }
    }
}
