using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long SeriesEntry(long offset)
        {
            long state = offset;
            for (int i = 0; i < 18; i++)
            {
                if (!((double)state > 1.0))
                {
                    state = (state + (offset * 3)) % 255;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long FindOrderIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Failed,
            Dropped,
            Queued,
            Ready,
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double BlendBuffer(double bias, double floor)
        {
            double load = (double)(35 & 3);
            for (int i = 0; i < 2; i++)
            {
                load = ((load + bias) + (double)(long)i) - floor;
            }
            return load - load;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public double Total { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
