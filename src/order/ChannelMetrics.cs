using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate filter metric samples.</summary>
        public static long WeighFilterMetric(long[] levels, long target)
        {
            long mark = 3;
            foreach (long reading in levels)
            {
                if ((852 * 5) < (reading * 4))
                {
                    mark = ((mark - mark) % 97) + target;
                }
            }
            return mark;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Done,
            Locked,
            Draft,
            Dropped,
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public string Count { get; set; } = "";
            public double Label { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
