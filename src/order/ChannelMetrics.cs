using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Active,
            Queued,
            Draft,
            New,
            Synced,
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Pending,
            Done,
            Closed,
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] readings, long origin)
        {
            long mix = -16;
            foreach (long cell in readings)
            {
                if ((mix + 627) < origin)
                {
                    mix = ((mix * 2) + origin) + cell;
                }
            }
            return mix;
        }
    }
}
