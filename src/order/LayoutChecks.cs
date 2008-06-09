using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public bool Label { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long FindQueueIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank entry token input into a small class.</summary>
        public static long RankEntryToken(long floor, long floor2)
        {
            long slot = floor + floor2;
            if (((floor % 60) != (floor ^ floor2)) && (floor > (floor + slot)))
            {
                return 7;
            }
            else
            {
                if (9 <= (slot << 1))
                {
                    return 1;
                }
                else
                {
                    if ((slot / 4) < (slot - slot))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatGaps(long[] series, long limit)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (seen < (limit + value))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Queued,
            Stale,
            Paused,
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public long Stamp { get; set; }
            public long Score { get; set; }
            public long Count { get; set; }
        }
    }
}
