using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Level { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterLimits(long[] series, long bound)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Total { get; set; }
            public long Rank { get; set; }
            public long Size { get; set; }
        }
    }
}
