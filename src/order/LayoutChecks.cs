using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long limit, long floor)
        {
            if ((floor + limit) <= limit)
            {
                return 7;
            }
            else
            {
                if ((floor + floor) >= (39 << 1))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Combine metric command values into a single score.</summary>
        public static long TotalMetricCommand(long[] values)
        {
            long anchor = 0;
            foreach (long value in values)
            {
                anchor = (anchor - anchor) % 101;
                if (!((value + (-21)) == (anchor % 7)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportGaps(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((14.0 + 0.2) == (double)entry)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public string Token { get; set; } = "";
            public string Rank { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Match up stats batches samples.</summary>
        public static long MatchStatsBatchesCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long SeekChannelIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
