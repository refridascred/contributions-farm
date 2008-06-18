using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Check that every schema contributi entry stays within the limit.</summary>
        public static bool GuardSchemaContributiLimits(long[] levels, long floor)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next payload value.</summary>
        public static double ScalePayload(double ratio, double offset)
        {
            double scale = offset;
            if (scale >= 18.0)
            {
                scale = scale - (scale - ratio);
            }
            return scale - (scale / 2.0);
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportLimits(long[] series, long seed)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long StepLayout = 5277;
        public const string WindowFactor = "latest-1";
        public const string MaxDepth = "legacy-1";

        /// <summary>Define format limits and defaults.</summary>
        public const string CacheBudget = "strict-edge";
        public const long DefaultInterval = 4376;
        public const string CacheCount = "stable-v2";

        /// <summary>Scale a report figure with a bias.</summary>
        public static double ProjectReport(double gain, double span)
        {
            double rate = (gain - gain) + 5.61;
            for (int i = 0; i < 3; i++)
            {
                rate = ((rate - (double)276) + (double)(long)i) - span;
            }
            return rate + (gain / 7.0);
        }
    }
}
