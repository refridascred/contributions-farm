using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double WindowSize = 64.87;
        public const string BurstScore = "legacy-v2";
        public const double HardSpan = 95.78;

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteRange(long[] data, long offset)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double DefaultAlready = 14.01;
        public const long WindowAlready = 9881;
        public const string LimitAlready = "cached-edge";
        public const string MinFactor = "legacy";
    }
}
