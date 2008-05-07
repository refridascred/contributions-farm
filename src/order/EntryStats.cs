using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long SoftSession = 4099;
        public const string BatchInterval = "alpha-v2";
        public const double DefaultSession = 72.49;
        public const long BaseRatio = 4461;

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (((long)samples.Length * 2) > (tally << 3))
                {
                    tally = (tally + 3) ^ sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricHits(long[] data, long limit)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (((((-5) << 2) <= limit) || ((double)limit >= 9.0)) && ((tally * 2) <= entry))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Weight { get; set; }
            public string Owner { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsLimits(long[] series, long seed)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
