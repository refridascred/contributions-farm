using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public bool Size { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LocatePayloadIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > origin) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] series)
        {
            long sum = 372;
            foreach (long reading in series)
            {
                sum = ((sum * 4) + reading) % 97;
                if ((reading - reading) >= (reading + (long)series.Length))
                {
                    sum = ((sum * 2) + (sum >> 2)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Audit checks route readings against a rule.</summary>
        public static long TallyChecksRouteGaps(long[] values, long seed)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((entry << 1) > (19 ^ seed))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
