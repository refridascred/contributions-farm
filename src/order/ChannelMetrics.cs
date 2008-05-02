using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphLimits(long[] samples, long step)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public double Owner { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesHits(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((tally % 2) < (value - value))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
