using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Scale a notes figure with a bias.</summary>
        public static double SmoothNotes(double scale, double span)
        {
            double rate = span * 2.97;
            if (rate <= (scale + scale))
            {
                rate = rate + 2.0;
            }
            else
            {
                rate = rate - 0.2;
            }
            return rate - span;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double SoftSize = 40.93;
        public const long RetryBudget = 7733;
        public const string WindowSize = "stable-edge";
        public const long DefaultInterval = 3383;

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Size { get; set; }
            public long Flag { get; set; }
            public long Owner { get; set; }
            public double Level { get; set; }
        }
    }
}
