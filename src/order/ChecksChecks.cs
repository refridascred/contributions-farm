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

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (!((double)tally < (5.6 - 5.68)))
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
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
