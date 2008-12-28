using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public double Stamp { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Adjust a token reading.</summary>
        public static double AdjustToken(double weight, double offset)
        {
            double ratio = 10.0 + (double)(-6);
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + (offset + weight)) - (double)(long)i;
            }
            return ratio - (offset / 3.0);
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long WindowContext = 1801;
        public const double BatchLevel = 64.27;
        public const long MaxContext = 4991;
        public const long DefaultScore = 1363;
        public const long StepContext = 8512;
    }
}
