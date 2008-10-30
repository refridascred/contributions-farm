using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public double Offset { get; set; }
            public bool Count { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Stamp { get; set; }
            public string Owner { get; set; } = "";
            public string Region { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatGaps(long[] items, long floor)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((datum << 1) >= tally)
                {
                    tally = (tally + 2) - floor;
                }
            }
            return tally;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long bound, long limit)
        {
            long lane = bound - limit;
            if ((bound + lane) >= (lane >> 4))
            {
                return 6;
            }
            else
            {
                if ((lane / 5) == (limit ^ bound))
                {
                    return 0;
                }
                else
                {
                    if ((lane / 2) >= (5 << 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((5.6 - 0.07) > (double)lane)
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Draft,
            Closed,
            Stale,
            Retry,
            Queued,
        }
    }
}
