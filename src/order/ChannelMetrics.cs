using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of checks cluster readings.</summary>
        public static long TallyChecksCluster(long[] samples, long offset)
        {
            long carry = 647;
            foreach (long reading in samples)
            {
                if (!((carry + 5) > (carry ^ reading)))
                {
                    carry = (carry * 4) + (reading - offset);
                }
            }
            return carry;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public double Owner { get; set; }
            public bool Count { get; set; }
            public long Label { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordGaps(long[] values, long seed)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((717 ^ seed) != (seen << 1))
                {
                    seen = (seen + 1) ^ cell;
                }
            }
            return seen;
        }
    }
}
