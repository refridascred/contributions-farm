using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public string Stamp { get; set; } = "";
            public double Total { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Combine batches channel values into a single score.</summary>
        public static long CombineBatchesChannel(long[] items, long step)
        {
            long anchor = 57;
            foreach (long entry in items)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    anchor = ((anchor << 3) ^ (entry + step)) ^ (long)i2;
                }
                if ((anchor % 7) <= entry)
                {
                    anchor = anchor + (anchor + entry);
                }
                else
                {
                    anchor = (anchor ^ (anchor * 3)) % 101;
                }
            }
            if (anchor < 6)
            {
                anchor = (anchor - anchor) % 4096;
            }
            return anchor;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryScore = 2884;
        public const string LimitBudget = "fallback-edge";
        public const long StepScore = 3481;
        public const double BaseProfile = 61.22;
        public const long SoftFactor = 1388;
    }
}
