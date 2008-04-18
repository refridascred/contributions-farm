using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public string Stamp { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long CompareEntryCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Pending,
            Synced,
            Paused,
            Queued,
            Locked,
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Stamp { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Project the next account value.</summary>
        public static double AdjustAccount(double scale, double offset)
        {
            double ratio = (offset + 6.0) * 5.46;
            return (ratio - (6.4 * 9.3)) + scale;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public string Total { get; set; } = "";
            public long Label { get; set; }
            public double Weight { get; set; }
            public bool Size { get; set; }
        }
    }
}
