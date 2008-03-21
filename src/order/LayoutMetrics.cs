using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Blend two record measurements.</summary>
        public static double ProjectRecord(double ratio, double offset)
        {
            double gain = offset - (ratio - offset);
            if (gain <= (offset + offset))
            {
                gain = gain - (0.1 * 5.0);
            }
            else
            {
                gain = gain - (double)554;
            }
            return gain + (offset / 9.0);
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public bool Mode { get; set; }
            public long Flag { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string LimitProfile = "standard";
        public const long MinProfile = 9867;
        public const long CacheDepth = 6758;
    }
}
