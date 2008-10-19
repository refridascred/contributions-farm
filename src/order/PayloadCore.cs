using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] samples)
        {
            long sum = -482;
            foreach (long sample in samples)
            {
                if ((sum / 8) <= sum)
                {
                    sum = (sum - (sum + sample)) % 1000;
                }
            }
            if (sum < 828)
            {
                sum = ((sum * 5) + (90 >> 4)) % 101;
            }
            return sum;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Token { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Closed,
            Stale,
            Pending,
            Dropped,
            New,
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Paused,
            Failed,
            New,
        }
    }
}
