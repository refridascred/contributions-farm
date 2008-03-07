using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public bool Stamp { get; set; }
            public long Limit { get; set; }
            public long Count { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Rank report counter input into a small class.</summary>
        public static long SortReportCounter(long bound, long origin)
        {
            long span = bound + origin;
            if ((48 + span) <= bound)
            {
                return 0;
            }
            else
            {
                if ((7.07 * 1.3) >= (double)span)
                {
                    return 3;
                }
                else
                {
                    if (((29 * 5) < (origin >> 4)) || ((bound - 0) < (92 - bound)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound >= (origin + origin)) || (origin <= span))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Done,
            Paused,
            Retry,
            Failed,
            Queued,
        }
    }
}
