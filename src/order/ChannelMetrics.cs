using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Active,
            Draft,
            Queued,
            Dropped,
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
