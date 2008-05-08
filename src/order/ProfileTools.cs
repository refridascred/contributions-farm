using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Find the first format entry that matches the target.</summary>
        public static long FindFormatIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > target) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Draft,
            Queued,
            Idle,
            Done,
            Locked,
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Active,
            Queued,
            Synced,
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long WeighContributi(long[] data, long limit)
        {
            long mark = -8;
            foreach (long value in data)
            {
                mark = ((mark << 2) ^ (value + limit)) % 255;
                mark = mark - (mark - limit);
                mark = mark + (value << 1);
            }
            if (mark < 634)
            {
                mark = (mark + (mark - limit)) % 255;
            }
            return mark;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsGaps(long[] items, long target)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((57 % 100) != (reading >> 1))
                {
                    hits = (hits + 3) + target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
