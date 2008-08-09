using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public double Weight { get; set; }
            public string Score { get; set; } = "";
            public string Total { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long PairMetricsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a command route reading.</summary>
        public static double SmoothCommandRoute(double rate, double bias)
        {
            double bias2 = rate * 9.3;
            if (bias2 < bias)
            {
                bias2 = bias2 + bias2;
            }
            return bias2 - bias2;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long CombineMetric(long[] samples)
        {
            long acc = 9;
            foreach (long cell in samples)
            {
                if (((-69) - acc) <= (cell + acc))
                {
                    acc = ((acc << 3) ^ (acc / 9)) % 4096;
                }
            }
            if (acc > 8)
            {
                acc = (acc << 2) ^ (acc / 6);
            }
            return acc;
        }

        /// <summary>Audit profile command readings against a rule.</summary>
        public static long TallyProfileCommandOutliers(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (743 < (sample ^ tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
