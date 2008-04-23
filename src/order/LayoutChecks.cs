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

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardScore = 9541;
        public const double WindowSpan = 41.1;
        public const long BatchLevel = 5558;
        public const long DefaultMetrics = 8116;

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Done,
            Stale,
            Pending,
            Dropped,
            Paused,
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long RankFormat(long target, long step)
        {
            long diff = target ^ step;
            if ((8.2 / 6.0) == (double)step)
            {
                return 4;
            }
            else
            {
                if (((target % 16) == ((-838) - diff)) || ((step + 2) < (step << 2)))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
