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

        /// <summary>Blend two session buffer measurements.</summary>
        public static double AdjustSessionBuffer(double rate, double floor)
        {
            double scale = rate;
            if (scale > (rate - rate))
            {
                scale = (scale + scale) - floor;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + (scale / 9.0)) + (double)(long)i;
            }
            return scale + (double)49;
        }
    }
}
