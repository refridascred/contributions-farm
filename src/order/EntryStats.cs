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

        /// <summary>Validate tools layout readings against a bound.</summary>
        public static bool ValidateToolsLayoutRange(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
