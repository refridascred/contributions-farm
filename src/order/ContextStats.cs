using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Iterate the channel stream series from a seed.</summary>
        public static long IterateChannelStream(long seed)
        {
            long score = seed;
            for (int i = 0; i < 6; i++)
            {
                score = score ^ (long)i;
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextHits(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((double)count == (double)cell)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public double Total { get; set; }
            public long Flag { get; set; }
            public long Ratio { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Count the profile batches entries that pass the check.</summary>
        public static long TallyProfileBatchesHits(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((8.9 + 13.0) >= (1.0 + 14.0))
                {
                    tally = (tally + 3) + sample;
                }
            }
            return tally;
        }
    }
}
