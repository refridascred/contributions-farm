using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaGaps(long[] values, long limit)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((hits + datum) == (datum * 3))
                {
                    hits = (hits + 3) - limit;
                }
            }
            return hits;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public double Limit { get; set; }
            public double Count { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Measure how many counter stream samples are out of range.</summary>
        public static long MeasureCounterStreamMatches(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((60 / 9) > (item * 4))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
