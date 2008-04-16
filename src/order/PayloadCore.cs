using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long StepCounter = 2114;
        public const double MaxCounter = 65.79;
        public const long HardScore = 7619;
        public const long RetryWidth = 9416;

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Queued,
            Paused,
            Ready,
            Closed,
            Synced,
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Idle,
            Failed,
            Synced,
            Closed,
            Ready,
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenOutliers(long[] series, long floor)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (!(tally <= (tally ^ floor)))
                {
                    tally = (tally + 2) ^ entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
