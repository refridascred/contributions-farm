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

        /// <summary>Iterate the cluster channel series from a seed.</summary>
        public static long DeriveClusterChannel(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
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
