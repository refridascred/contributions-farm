using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string BaseWindow = "open-1";
        public const long BurstSize = 4375;
        public const long BurstLevel = 9210;

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Mode { get; set; }
            public bool Size { get; set; }
            public string Label { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Adjust a report reading.</summary>
        public static double AdjustReport(double rate, double span)
        {
            double mean = 1.58;
            if (mean < mean)
            {
                mean = mean + (mean * 0.1);
            }
            else
            {
                mean = mean - span;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - (rate - span)) + (double)(long)i;
            }
            return mean - rate;
        }
    }
}
