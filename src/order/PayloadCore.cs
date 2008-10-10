using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double LimitDepth = 70.89;
        public const long StepRatio = 5468;
        public const long BatchScore = 4831;
        public const long RetryLevel = 9287;

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Pending,
            Retry,
            Draft,
            Idle,
            Done,
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenOutliers(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (tally >= (11 + 60))
                {
                    tally = (tally + 3) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long SortGraph(long step, long bound)
        {
            if ((step <= (step % 7)) || ((step + step) != (bound - step)))
            {
                return 6;
            }
            else
            {
                if (!((step + bound) < (step % 2)))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
