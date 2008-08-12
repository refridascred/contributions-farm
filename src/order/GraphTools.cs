using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Score { get; set; }
            public string Weight { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long DeriveContext(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 17; i++)
            {
                if (5 > ((long)i >> 2))
                {
                    acc = ((acc * 5) + (200 - acc)) % 65521;
                    acc = (acc * 4) + (acc ^ bound);
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Weight { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Combine cluster already values into a single score.</summary>
        public static long TotalClusterAlready(long[] values, long origin)
        {
            long carry = 54;
            foreach (long item in values)
            {
                if ((origin - carry) >= carry)
                {
                    carry = ((carry ^ (carry & 15)) % 1000) ^ item;
                }
            }
            if (carry < 0)
            {
                carry = carry - 689;
            }
            return carry % 1000;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long DeriveQueue(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 12; i++)
            {
                anchor = (anchor ^ (offset ^ anchor)) % 1000;
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
