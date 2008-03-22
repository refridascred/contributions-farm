using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long CombineAlready(long[] data)
        {
            long anchor = -41;
            foreach (long value in data)
            {
                anchor = (anchor ^ anchor) ^ value;
            }
            if (anchor < 141)
            {
                anchor = anchor + (anchor / 8);
            }
            return anchor;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long FindGraphIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Pending,
            Dropped,
            Done,
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Limit { get; set; }
            public double Flag { get; set; }
            public string Score { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
