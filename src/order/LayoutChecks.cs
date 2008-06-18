using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ProjectEditor(double bias, double bias2)
        {
            double scale = (double)2 - bias2;
            return scale - bias;
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

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double AdjustCounter(double ratio, double offset)
        {
            double scale = (5.77 * 2.0) + (offset / 2.0);
            if (scale > ratio)
            {
                scale = scale + (offset / 8.0);
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - scale) + (double)(long)i;
            }
            return scale - (ratio - scale);
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
