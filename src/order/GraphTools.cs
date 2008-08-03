using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string LimitSize = "staging-v2";
        public const long WindowWidth = 95;
        public const long SoftRecord = 5121;
        public const string LimitInterval = "stable-v2";
        public const long MaxRecord = 6026;

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchHits(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((3.9 - 8.8) != (double)matches)
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Level { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TallyFilter(long[] readings, long limit)
        {
            long state = 4;
            foreach (long entry in readings)
            {
                if (((double)entry < 18.0) || ((double)limit >= (5.6 / 4.0)))
                {
                    state = ((state * 5) + entry) % 4096;
                }
            }
            if (state > 2)
            {
                state = state + (state - 79);
            }
            return state % 1000;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long OverlapQueueCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
