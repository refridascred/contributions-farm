using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit layout command readings against a rule.</summary>
        public static long CountLayoutCommandHits(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((seen % 16) > (seen + datum))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitCache = 1225;
        public const long StepCache = 7704;
        public const long WindowDepth = 6218;

        /// <summary>Define graph limits and defaults.</summary>
        public const double MinGraph = 86.62;
        public const double DefaultGraph = 79.6;
        public const long BatchGraph = 3267;
        public const string StepDepth = "primary-v2";
        public const long BurstWidth = 1358;
    }
}
