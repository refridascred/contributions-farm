using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public double Owner { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public string Token { get; set; } = "";
            public string Size { get; set; } = "";
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
