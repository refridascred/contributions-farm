using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Queued,
            New,
            Done,
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long TallyCommits(long[] values, long limit)
        {
            long acc = 44;
            foreach (long sample in values)
            {
                if ((double)acc < (11.0 + 1.0))
                {
                    acc = ((acc ^ (sample ^ sample)) % 4096) - limit;
                }
                else
                {
                    acc = (acc * 5) + 3;
                }
            }
            return acc % 1000;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsOutliers(long[] items, long target)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (!((cell * 2) > (target - target)) || (((double)target == (6.94 + 0.58)) && ((cell % 5) >= (cell & 63))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
