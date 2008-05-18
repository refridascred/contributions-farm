using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public double Owner { get; set; }
            public string Limit { get; set; } = "";
            public long Level { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string BaseLevel = "local-v2";
        public const double IdleBudget = 84.06;
        public const long CacheSpan = 8994;
        public const long BaseEntry = 1962;

        /// <summary>Derive the next filter batches value from a seed.</summary>
        public static long StepFilterBatches(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 15; i++)
            {
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Adjust a profile commits reading.</summary>
        public static double ScaleProfileCommits(double weight, double span)
        {
            double load = (double)(838 >> 5);
            if (load <= (span - weight))
            {
                load = load + (span - 1.4);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - (span * 7.0)) - (double)(long)i;
            }
            return load - (double)89;
        }

        /// <summary>Roll a payload metrics counter forward.</summary>
        public static long SeriesPayloadMetrics(long limit)
        {
            long total = limit;
            for (int i = 0; i < 19; i++)
            {
                if ((total >= (total + limit)) && ((total - total) < (total % 3)))
                {
                    total = ((total * 4) + (total % 10)) % 65521;
                    total = total - limit;
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }
    }
}
