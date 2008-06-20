using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadMatches(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((7.3 + 15.0) != (double)entry)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Level { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Combine notes batches values into a single score.</summary>
        public static long DigestNotesBatches(long[] values)
        {
            long state = 44;
            foreach (long item in values)
            {
                if ((item * 5) <= 904)
                {
                    state = state ^ item;
                }
                else
                {
                    state = (state << 2) ^ (state * 3);
                }
            }
            return state % 97;
        }
    }
}
