using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Draft,
            Retry,
            Pending,
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long offset, long target)
        {
            if ((5.13 * 1.39) == (double)offset)
            {
                return 4;
            }
            else
            {
                if ((54 - 282) == (offset + offset))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Failed,
            Active,
            Dropped,
        }
    }
}
