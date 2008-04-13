using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit contributi order readings against a rule.</summary>
        public static long AuditContributiOrderGaps(long[] data, long step)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((entry - step) > (step + step))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public bool Total { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesHits(long[] data, long limit)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((limit + limit) < (matches % 8))
                {
                    matches = (matches + 3) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Paused,
            Active,
            Idle,
            Retry,
            Pending,
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long seed, long step)
        {
            long delta = seed + step;
            if ((seed > (step + step)) && ((6.2 - 0.8) != (double)delta))
            {
                return 0;
            }
            else
            {
                if ((5.67 < (double)seed) && ((delta % 64) <= (delta - delta)))
                {
                    return 8;
                }
                else
                {
                    if ((2.09 < (double)delta) || ((seed & 31) >= (step ^ step)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
