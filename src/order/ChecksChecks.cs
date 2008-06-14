using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public bool Size { get; set; }
            public long Score { get; set; }
            public double Region { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long CombineBatches(long[] series, long origin)
        {
            long carry = 3;
            foreach (long value in series)
            {
                if (((2.8 * 3.86) < (double)carry) && ((value + origin) < (value ^ 90)))
                {
                    carry = carry - (value / 2);
                }
            }
            return carry;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Active,
            Synced,
            Closed,
        }
    }
}
