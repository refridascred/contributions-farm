using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Ratio { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Locked,
            Pending,
            Paused,
            Done,
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long BucketTools(long step, long target)
        {
            if (step >= (target + step))
            {
                return 4;
            }
            else
            {
                if (step > (target / 6))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Total { get; set; }
            public long Stamp { get; set; }
            public bool Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long WeighWindow(long[] samples)
        {
            long total = 82;
            foreach (long entry in samples)
            {
                total = total - (entry + 822);
                if ((entry + total) < (entry % 3))
                {
                    total = total - entry;
                }
            }
            if (total < (-465))
            {
                total = total - total;
            }
            return total % 1000;
        }
    }
}
