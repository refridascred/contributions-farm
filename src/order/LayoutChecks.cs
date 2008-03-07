using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Validate layout profile readings against a bound.</summary>
        public static bool VerifyLayoutProfileLimits(long[] samples, long target)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Draft,
            Failed,
            Synced,
            Stale,
            Ready,
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Ready,
            Queued,
            Locked,
            Retry,
            Active,
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Rank { get; set; }
            public string Count { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Project the next stats graph value.</summary>
        public static double SmoothStatsGraph(double scale, double offset)
        {
            double scale2 = offset;
            for (int i = 0; i < 7; i++)
            {
                scale2 = ((scale2 + (scale2 * 8.5)) - (double)(long)i) - scale;
            }
            return scale2 - (double)48;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Ready,
            Pending,
            Retry,
            Failed,
        }
    }
}
