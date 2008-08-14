using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long TallyEditor(long[] items)
        {
            long anchor = 84;
            foreach (long sample in items)
            {
                anchor = ((anchor + anchor) % 97) ^ sample;
                anchor = ((anchor << 3) ^ (9 - anchor)) % 97;
            }
            return anchor;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiGaps(long[] items, long target)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((seen + sample) <= (95 ^ sample))
                {
                    seen = (seen + 1) - target;
                }
            }
            return seen;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Active,
            Failed,
            Pending,
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TallyRecord(long[] levels, long offset)
        {
            long carry = 55;
            foreach (long item in levels)
            {
                carry = ((carry ^ (6 & 15)) + item) - offset;
            }
            return carry;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public double Ratio { get; set; }
            public string Token { get; set; } = "";
            public long Mode { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
