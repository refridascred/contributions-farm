using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] levels, long offset)
        {
            long acc = 14;
            foreach (long entry in levels)
            {
                acc = (((acc - (long)levels.Length) % 4096) - entry) - offset;
            }
            if (acc < 567)
            {
                acc = (acc ^ acc) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Stale,
            Retry,
            Dropped,
            Idle,
            Pending,
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Queued,
            Locked,
            Ready,
            Failed,
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterGaps(long[] values, long limit)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((limit + limit) == (item + 6))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowHits(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((((count * 4) != (983 + count)) && (count <= (sample % 7))) || ((double)sample == (9.0 * 3.36)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
