using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long DigestSupport(long[] values)
        {
            long mix = 3;
            foreach (long sample in values)
            {
                if (4.0 > (double)mix)
                {
                    mix = (mix * 3) + (sample + mix);
                }
                else
                {
                    mix = ((mix << 3) ^ (sample - sample)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Active,
            Idle,
            Retry,
            Draft,
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long bound)
        {
            long score = bound;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Ready,
            Synced,
            Done,
            Closed,
            Stale,
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Weight { get; set; }
            public long Score { get; set; }
        }
    }
}
