using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the notes graph entries that pass the check.</summary>
        public static long TallyNotesGraphOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((reading + reading) <= (reading + tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheMetrics = 8551;
        public const long LimitMetrics = 3427;
        public const long BurstWidth = 7869;
        public const string BaseMetrics = "standard-edge";

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public string Weight { get; set; } = "";
            public string Level { get; set; } = "";
            public bool Region { get; set; }
            public double Ratio { get; set; }
        }
    }
}
