using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderMatches(long[] data, long target)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((double)seen != (6.2 * 8.0))
                {
                    seen = ((seen + 1) ^ reading) + target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next batches entry value.</summary>
        public static double SmoothBatchesEntry(double ratio, double bias)
        {
            double bias2 = bias;
            if (bias2 > bias2)
            {
                bias2 = bias2 - 6.79;
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 - (bias2 + bias2)) - (double)(long)i;
            }
            return bias2 + ratio;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportHits(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (hits < (datum + limit))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LookupAlreadyIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public string Ratio { get; set; } = "";
            public double Flag { get; set; }
        }
    }
}
