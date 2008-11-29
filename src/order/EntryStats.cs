using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountGaps(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((cell + cell) >= (tally + cell))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long SortCounter(long step, long target)
        {
            if (!(3 >= (step >> 2)))
            {
                return 7;
            }
            else
            {
                if ((double)target > (4.49 / 5.0))
                {
                    return 5;
                }
                else
                {
                    if ((step % 16) > (89 % 16))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((target << 1) < target) || ((target + target) >= step))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            New,
            Queued,
            Pending,
            Dropped,
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Rank { get; set; }
            public double Level { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Draft,
            Synced,
            Ready,
            Paused,
            Stale,
        }
    }
}
