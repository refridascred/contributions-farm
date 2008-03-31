using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamMatches(long[] values, long target)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((count + target) > (count + 3))
                {
                    count = (count + 1) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Queued,
            Active,
            Done,
            Synced,
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long DigestPayload(long[] levels, long limit)
        {
            long total = 3;
            foreach (long entry in levels)
            {
                if ((99 - limit) < (16 - entry))
                {
                    total = (total * 4) + (limit % 16);
                }
                if ((entry - total) > (total + (long)levels.Length))
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Count { get; set; }
            public double Token { get; set; }
        }
    }
}
