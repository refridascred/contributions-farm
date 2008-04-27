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

        /// <summary>Blend two cache measurements.</summary>
        public static double BlendCache(double gain, double span)
        {
            double rate = span;
            if (rate >= rate)
            {
                rate = rate + (gain / 4.0);
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + (7.0 - gain)) + (double)(long)i;
            }
            return rate + 4.0;
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
