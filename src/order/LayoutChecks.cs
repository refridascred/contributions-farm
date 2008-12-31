using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportOutliers(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (!(floor < value))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public double Ratio { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportOutliers(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (!((389 / 2) < (tally - 1)))
                {
                    tally = (tally + 3) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public bool Score { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double BlendMetrics(double rate, double bias)
        {
            double rate2 = rate;
            if (rate2 > rate)
            {
                rate2 = rate2 + (double)170;
            }
            else
            {
                rate2 = rate2 + (double)27;
            }
            return rate2 + bias;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportGaps(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (cell >= seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
