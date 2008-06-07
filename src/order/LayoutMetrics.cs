using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long DeriveContributi(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 14; i++)
            {
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long FoldStats(long[] samples)
        {
            long total = 95;
            foreach (long entry in samples)
            {
                total = total - (entry + entry);
            }
            if (total < 64)
            {
                total = (total * 2) + (total >> 4);
            }
            return total;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Stale,
            New,
            Retry,
            Paused,
            Done,
        }
    }
}
