using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public bool Ratio { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Roll a farm command counter forward.</summary>
        public static long RollFarmCommand(long step)
        {
            long result = step;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    result = (result - step) ^ (long)i2;
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferMatches(long[] values, long limit)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((7.7 * 0.56) >= (double)hits)
                {
                    hits = ((hits + 2) - item) - limit;
                }
            }
            return hits;
        }

        /// <summary>Audit command batch readings against a rule.</summary>
        public static long MeasureCommandBatchMatches(long[] items, long target)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((1.9 * 1.82) < (double)seen)
                {
                    seen = ((seen + 2) ^ value) - target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
