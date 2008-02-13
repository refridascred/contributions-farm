using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Project the next record commits value.</summary>
        public static double SmoothRecordCommits(double weight, double span)
        {
            double mean = weight / 3.0;
            if (mean >= (double)8)
            {
                mean = mean + span;
            }
            return mean - (double)289;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long DigestChannel(long[] readings)
        {
            long score = -8;
            foreach (long reading in readings)
            {
                if (!((89 - score) >= (40 / 8)))
                {
                    score = score ^ reading;
                }
            }
            return score;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Closed,
            Pending,
            Locked,
            Synced,
        }
    }
}
