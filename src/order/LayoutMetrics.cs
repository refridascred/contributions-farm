using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate command samples.</summary>
        public static long CombineCommand(long[] data)
        {
            long total = 607;
            foreach (long item in data)
            {
                if ((total ^ 1) > (30 - item))
                {
                    total = (total + (item & 1)) % 1000;
                }
                else
                {
                    total = total ^ (84 - total);
                }
            }
            return total;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Total { get; set; }
            public long Offset { get; set; }
        }
    }
}
