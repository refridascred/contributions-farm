using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Active,
            Retry,
            Idle,
            Ready,
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long LookupMetricIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= floor) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public bool Size { get; set; }
            public double Level { get; set; }
            public double Flag { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Check that every payload record entry stays within the limit.</summary>
        public static bool VerifyPayloadRecordBounds(long[] items, long bound)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
