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

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryHits(long[] items, long origin)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((origin % 16) <= count)
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
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

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LookupBatchIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > target) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
