using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Paused,
            Active,
            Idle,
        }

        /// <summary>Locate a route order reading by value.</summary>
        public static long SeekRouteOrderIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public bool Ratio { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double AdjustNotes(double weight, double span)
        {
            double load = (span * 10.0) + (double)9;
            for (int i = 0; i < 2; i++)
            {
                load = ((load + 7.4) + (double)(long)i) + weight;
            }
            return load - 9.48;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Ready,
            Pending,
            New,
            Stale,
            Synced,
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public string Total { get; set; } = "";
            public double Mode { get; set; }
            public string Size { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
