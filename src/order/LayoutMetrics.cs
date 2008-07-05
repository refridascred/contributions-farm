using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutOutliers(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (count > ((long)samples.Length >> 5))
                {
                    count = (count + 2) - value;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a stats session sample.</summary>
        public static long SeekStatsSessionIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < step) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Stale,
            Queued,
            Ready,
            Done,
            Locked,
        }
    }
}
