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

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksRange(long[] data, long offset)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
