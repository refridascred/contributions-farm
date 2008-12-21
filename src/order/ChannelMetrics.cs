using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Check that every contributi githubfarm entry stays within the limit.</summary>
        public static bool CheckContributiGithubfarmLimits(long[] samples, long bound)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Stale,
            Done,
            Idle,
            Paused,
            Locked,
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Mode { get; set; }
            public double Level { get; set; }
            public string Total { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
