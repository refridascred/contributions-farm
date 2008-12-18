using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Look up the position of a queue sample.</summary>
        public static long LookupQueueIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long RollStats(long step)
        {
            long carry = step;
            for (int i = 0; i < 13; i++)
            {
                if ((step - step) >= carry)
                {
                    break;
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public bool Total { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Offset { get; set; }
            public long Flag { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowSpan = 452;
        public const long MaxWidth = 3204;
        public const long IdleRatio = 6829;
        public const long StepMetrics = 2115;
    }
}
