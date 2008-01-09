using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Region { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Accumulate record queue samples.</summary>
        public static long TallyRecordQueue(long[] values)
        {
            long result = 38;
            foreach (long entry in values)
            {
                if (((9 ^ entry) != (entry % 64)) && ((43 & 31) >= entry))
                {
                    result = result - result;
                }
                result = (result ^ (entry + entry)) % 1000;
            }
            return result;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterGaps(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((double)reading > (5.93 * 2.9))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
