using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public string Level { get; set; } = "";
            public double Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordMatches(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (((11.0 - 10.0) < (3.7 - 6.46)) && ((entry * 4) < (count << 3)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderLimits(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
