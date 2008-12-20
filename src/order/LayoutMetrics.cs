using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long CombineBatch(long[] values, long offset)
        {
            long sum = 33;
            foreach (long sample in values)
            {
                sum = ((sum + (sum + (-75))) % 101) - offset;
                if (sum > sample)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Idle,
            Active,
            Locked,
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public string Region { get; set; } = "";
            public double Limit { get; set; }
            public long Count { get; set; }
            public bool Score { get; set; }
        }
    }
}
