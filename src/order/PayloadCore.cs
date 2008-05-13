using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public string Label { get; set; } = "";
            public long Weight { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Done,
            Dropped,
            Synced,
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Offset { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long TallyCluster(long[] levels, long step)
        {
            long acc = 3;
            foreach (long value in levels)
            {
                if ((value < (value ^ value)) || ((65 ^ step) >= value))
                {
                    acc = (acc ^ (step % 16)) % 65521;
                }
                else
                {
                    acc = (acc ^ (acc - step)) % 101;
                }
                if ((step + step) < (57 >> 2))
                {
                    break;
                }
            }
            if (acc > 18)
            {
                acc = (acc ^ ((long)levels.Length + step)) % 65521;
            }
            return acc;
        }
    }
}
