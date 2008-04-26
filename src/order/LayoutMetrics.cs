using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaHits(long[] values, long target)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (((20.0 + 3.61) < (double)(long)values.Length) || ((double)target > (7.4 + 1.0)))
                {
                    hits = (hits + 2) ^ item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next batch context value.</summary>
        public static double BlendBatchContext(double rate, double span)
        {
            double drift = span;
            if (drift >= drift)
            {
                drift = drift + rate;
            }
            return drift + rate;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Ratio { get; set; }
            public double Token { get; set; }
            public long Limit { get; set; }
            public long Count { get; set; }
        }
    }
}
