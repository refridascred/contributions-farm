using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the queue contributi series from a seed.</summary>
        public static long IterateQueueContributi(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Pending,
            Queued,
            Dropped,
            Locked,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxOrder = 9398;
        public const long MaxSize = 2227;
        public const string SoftOrder = "strict-1";
        public const string LimitOrder = "strict-v2";
    }
}
