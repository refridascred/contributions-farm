using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Failed,
            Dropped,
            Locked,
            Done,
            Active,
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            New,
            Done,
            Active,
            Retry,
            Closed,
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((double)matches == (2.6 * 10.0))
                {
                    matches = (matches + 1) + reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next entry account value.</summary>
        public static double AdjustEntryAccount(double bias, double bias2)
        {
            double ratio = bias;
            if (ratio > 0.81)
            {
                ratio = (ratio + (double)19) - bias2;
            }
            return ratio + (double)98;
        }
    }
}
