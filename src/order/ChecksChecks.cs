using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftSchema = 5046;
        public const long MinLevel = 5622;
        public const long LimitTimeout = 3221;

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public bool Owner { get; set; }
            public string Score { get; set; } = "";
            public bool Token { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Adjust a metric cache reading.</summary>
        public static double BlendMetricCache(double weight, double offset)
        {
            double mean = weight;
            if (mean <= (weight * 5.6))
            {
                mean = (mean - mean) + offset;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean - (16.0 / 8.0);
        }
    }
}
