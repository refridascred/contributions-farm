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

        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstQueue = 3866;
        public const long StepSpan = 506;
        public const double SoftSize = 5.98;

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
