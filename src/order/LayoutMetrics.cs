using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterGaps(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((double)count >= (double)entry) && (entry >= (0 + 69)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Offset { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long DeriveLayout(long origin)
        {
            long state = origin;
            for (int i = 0; i < 4; i++)
            {
                state = (state ^ (6 + (long)i)) % 101;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }
    }
}
