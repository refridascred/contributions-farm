using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Dropped,
            Closed,
            Ready,
            Stale,
            Locked,
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Synced,
            Stale,
            Locked,
            Closed,
            Retry,
        }

        /// <summary>Count the githubfarm queue entries that pass the check.</summary>
        public static long MeasureGithubfarmQueueMatches(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((double)count <= (15.0 / 9.0))
                {
                    count = (count + 3) - cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
