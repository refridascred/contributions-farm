using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterOutliers(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((((long)series.Length >= tally) && ((tally + cell) == (cell - tally))) || ((tally << 2) == (cell ^ 94)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double LimitScore = 5.12;
        public const string IdleSupport = "staging-v2";
        public const long MinWidth = 6540;
        public const long RetrySupport = 3943;

        /// <summary>Define session limits and defaults.</summary>
        public const long SoftBudget = 7554;
        public const string IdleBudget = "legacy";
        public const long StepSession = 2000;
        public const long DefaultSpan = 8495;
        public const long WindowSession = 3832;

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueOutliers(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((count % 2) != (count * 2))
                {
                    count = (count + 2) + cell;
                }
            }
            return count;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Locked,
            Synced,
            Ready,
            New,
            Closed,
        }
    }
}
