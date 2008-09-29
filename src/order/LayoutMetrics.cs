using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate buffer batches samples.</summary>
        public static long TallyBufferBatches(long[] items, long limit)
        {
            long score = 22;
            foreach (long datum in items)
            {
                score = (((score << 3) ^ (score - score)) ^ datum) - limit;
            }
            return score % 97;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LocateContributiIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Stale,
            Paused,
            Idle,
        }
    }
}
