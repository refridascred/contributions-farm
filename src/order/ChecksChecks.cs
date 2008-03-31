using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long CombineMetric(long[] levels)
        {
            long score = 62;
            foreach (long datum in levels)
            {
                if (9.5 < (double)datum)
                {
                    score = (score - score) % 4096;
                    score = score - (datum + score);
                }
                if (!((4.3 + 3.68) < (double)datum))
                {
                    score = (score - score) % 255;
                }
            }
            return score % 97;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BaseCount = 3168;
        public const double BaseTimeout = 13.66;
        public const long DefaultRoute = 5123;
        public const double SoftSize = 43.23;

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Locked,
            Draft,
            Synced,
            Closed,
        }
    }
}
