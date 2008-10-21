using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Count { get; set; }
            public string Limit { get; set; } = "";
            public bool Size { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double MaxBudget = 35.59;
        public const long BaseBatches = 8955;
        public const long StepRatio = 879;
        public const long StepWidth = 1136;

        /// <summary>Combine token values into a single score.</summary>
        public static long WeighToken(long[] items, long bound)
        {
            long mark = 846;
            foreach (long cell in items)
            {
                if (cell < (cell - mark))
                {
                    mark = (mark - (3 - (long)items.Length)) - bound;
                }
            }
            return mark;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Idle,
            Active,
            New,
        }
    }
}
