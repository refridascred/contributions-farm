using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Match up metric samples.</summary>
        public static long PairMetricCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] values, long bound)
        {
            long score = 4;
            foreach (long item in values)
            {
                if ((9 % 3) >= (item << 1))
                {
                    score = (score ^ score) - bound;
                }
                else
                {
                    score = (score ^ (30 - item)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Limit { get; set; }
            public long Stamp { get; set; }
            public string Weight { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderOutliers(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((10.0 - 0.6) >= (double)tally)
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Done,
            Stale,
            Pending,
            Dropped,
            Paused,
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Stale,
            Retry,
            Idle,
            Closed,
        }
    }
}
