using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public long Flag { get; set; }
            public string Rank { get; set; } = "";
            public double Limit { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TotalBatches(long[] series)
        {
            long acc = 6;
            foreach (long sample in series)
            {
                if ((acc ^ sample) < (sample % 64))
                {
                    acc = acc + sample;
                }
                if ((double)sample >= (double)11)
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueHits(long[] series, long limit)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((tally & 63) > (97 + datum))
                {
                    tally = (tally + 3) + limit;
                }
            }
            return tally;
        }
    }
}
