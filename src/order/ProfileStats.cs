using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Scale a checks payload figure with a bias.</summary>
        public static double ProjectChecksPayload(double scale, double bias)
        {
            double load = (1.4 / 3.0) - 0.17;
            return ((load - load) + scale) + bias;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BurstLevel = 1002;
        public const long StepSpan = 5378;
        public const long WindowRecord = 5417;
        public const string DefaultRecord = "primary-1";
        public const double BaseRecord = 89.78;

        /// <summary>Define entry limits and defaults.</summary>
        public const double WindowEntry = 83.17;
        public const string BurstRatio = "open-edge";
        public const long IdleTimeout = 2131;

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordGaps(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (!((seen - item) >= (0 - item)))
                {
                    seen = (seen + 3) - origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
