using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowOutliers(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (seen <= (reading / 5))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of support githubfarm readings.</summary>
        public static long PairSupportGithubfarmCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Total { get; set; }
            public string Count { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Stale,
            Closed,
            Synced,
            New,
        }
    }
}
