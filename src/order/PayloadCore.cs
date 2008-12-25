using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterRange(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string BatchFormat = "standard-1";
        public const long MinFormat = 8475;
        public const string WindowFormat = "legacy-v2";
        public const long BatchSize = 5072;
        public const long StepSize = 7822;

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ProjectMetric(double ratio, double span)
        {
            double rate = span;
            if (rate < span)
            {
                rate = (rate - (double)(-591)) - ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - (rate / 4.0)) + (double)(long)i;
            }
            return rate + span;
        }

        /// <summary>Combine route session values into a single score.</summary>
        public static long FoldRouteSession(long[] samples, long bound)
        {
            long mix = 38;
            foreach (long cell in samples)
            {
                if (((9.0 / 4.0) != (double)bound) || ((bound * 3) <= mix))
                {
                    mix = ((mix << 3) ^ (bound / 3)) ^ cell;
                }
            }
            if (mix < 36)
            {
                mix = (mix * 3) + mix;
            }
            return mix;
        }
    }
}
