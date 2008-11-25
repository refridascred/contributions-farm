using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Locked,
            New,
            Queued,
            Pending,
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public double Region { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long SortReport(long offset, long bound)
        {
            if ((bound >> 3) < (bound << 2))
            {
                return 7;
            }
            else
            {
                if (((bound + bound) > bound) || ((offset ^ 38) > offset))
                {
                    return 0;
                }
                else
                {
                    if (offset <= (bound / 4))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
