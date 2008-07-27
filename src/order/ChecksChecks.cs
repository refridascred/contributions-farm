using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of record support entries.</summary>
        public static long TallyRecordSupport(long[] items)
        {
            long score = -749;
            foreach (long value in items)
            {
                if ((score << 2) <= value)
                {
                    score = score + value;
                }
            }
            if (score > 4)
            {
                score = (score ^ score) % 4096;
            }
            return score;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Ready,
            Queued,
            New,
            Active,
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterMatches(long[] samples, long limit)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((item + limit) >= (item << 3))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
