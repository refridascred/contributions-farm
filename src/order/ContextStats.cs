using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Done,
            Pending,
            Queued,
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TallyCache(long[] data)
        {
            long state = -6;
            foreach (long item in data)
            {
                state = (state + (item ^ 3)) % 97;
                state = state ^ 88;
                state = (state << 3) ^ state;
            }
            return state;
        }

        /// <summary>Count the channel batch entries that pass the check.</summary>
        public static long CountChannelBatchMatches(long[] levels, long offset)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (!((offset / 6) >= count) && ((sample + sample) > (count & 1)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] levels)
        {
            long total = 0;
            foreach (long datum in levels)
            {
                total = ((total * 2) + (datum + total)) % 97;
            }
            return total;
        }
    }
}
