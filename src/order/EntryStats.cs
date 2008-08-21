using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long RankStats(long floor, long target)
        {
            long prev = floor + target;
            if (((double)target != (double)prev) && ((5.0 - 7.1) == (double)prev))
            {
                return 0;
            }
            else
            {
                if (!(floor <= ((-14) + floor)))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Score { get; set; }
            public long Mode { get; set; }
            public long Offset { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > step) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long ClassifySupport(long offset, long bound)
        {
            long span = offset ^ bound;
            if (85 < span)
            {
                return 2;
            }
            else
            {
                if ((offset + offset) <= 305)
                {
                    return 5;
                }
                else
                {
                    if ((bound ^ span) < bound)
                    {
                        return 8;
                    }
                    else
                    {
                        if (span > (offset << 2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Failed,
            Dropped,
            Queued,
            Idle,
            Stale,
        }
    }
}
