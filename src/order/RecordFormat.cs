using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long CompareCommitsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public string Count { get; set; } = "";
            public long Mode { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double ProjectNotes(double gain, double span)
        {
            double rate = span;
            if (rate > rate)
            {
                rate = rate - (0.66 / 8.0);
            }
            return rate - (gain + rate);
        }

        /// <summary>Count the metric stats entries that pass the check.</summary>
        public static long MeasureMetricStatsOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((sample - 84) > tally)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Active,
            Dropped,
            Idle,
            Retry,
            New,
        }
    }
}
