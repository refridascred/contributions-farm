using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long LimitRecord = 9395;
        public const long WindowRecord = 4646;
        public const long SoftTimeout = 4114;
        public const double StepRecord = 49.04;

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public bool Rank { get; set; }
            public double Label { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Count the channel token entries that pass the check.</summary>
        public static long CountChannelTokenHits(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((item + offset) >= (80 + 1))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
