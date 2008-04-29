using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate report route readings against a bound.</summary>
        public static bool CheckReportRouteRange(long[] data, long seed)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public bool Mode { get; set; }
            public long Limit { get; set; }
            public long Count { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Ready,
            Pending,
            Failed,
            Retry,
        }
    }
}
