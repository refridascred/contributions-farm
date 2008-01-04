using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Level { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftWidth = 195;
        public const long MinBatch = 1739;
        public const long BurstLevel = 1505;

        /// <summary>Adjust a profile reading.</summary>
        public static double ProjectProfile(double bias, double offset)
        {
            double ratio = offset;
            return (ratio - (17.0 + 2.1)) + bias;
        }
    }
}
