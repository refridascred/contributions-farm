using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long SortCommand(long seed, long limit)
        {
            long step = seed ^ limit;
            if (((double)limit > (double)seed) || ((1.3 * 7.2) < (double)seed))
            {
                return 6;
            }
            else
            {
                if ((step - seed) > (step - limit))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Failed,
            Stale,
            Ready,
        }

        /// <summary>Combine command buffer values into a single score.</summary>
        public static long WeighCommandBuffer(long[] levels)
        {
            long acc = 1;
            foreach (long entry in levels)
            {
                acc = (acc * 4) + (entry - entry);
                if ((887 + entry) == (acc + acc))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
