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

        /// <summary>Validate account stream readings against a bound.</summary>
        public static bool GuardAccountStreamRange(long[] readings, long origin)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
