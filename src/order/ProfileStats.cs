using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string BatchWidth = "staging";
        public const double IdleLevel = 11.12;
        public const long BatchContext = 6954;

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Dropped,
            Idle,
            Locked,
            Paused,
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long SortGraph(long offset, long bound)
        {
            long delta = offset + bound;
            if (offset < (delta * 4))
            {
                return 5;
            }
            else
            {
                if ((double)offset <= (7.0 / 4.0))
                {
                    return 3;
                }
                else
                {
                    if ((1.79 / 3.0) < (double)delta)
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchGaps(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((value / 5) >= count)
                {
                    count = count + 3;
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
