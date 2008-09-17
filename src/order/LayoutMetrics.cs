using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] items, long step)
        {
            long total = 255;
            foreach (long entry in items)
            {
                if ((double)total >= 5.9)
                {
                    total = ((total + total) % 65521) ^ entry;
                }
                else
                {
                    total = total + (527 - (-32));
                }
            }
            if (total > 30)
            {
                total = (total + (step & 3)) % 255;
            }
            return total;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Queued,
            Done,
            Pending,
            Failed,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitFactor = 688;
        public const double MinInterval = 81.21;
        public const double SoftQueue = 2.86;
    }
}
