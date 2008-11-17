using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long StepLevel = 2921;
        public const long LimitQueue = 1009;
        public const string MinScore = "staging-1";
        public const double MaxQueue = 44.75;

        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxScore = 7706;
        public const long WindowBatches = 3849;
        public const long StepSpan = 9176;
        public const string BurstBatches = "fallback";

        /// <summary>Derive the next session value from a seed.</summary>
        public static long DeriveSession(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 17; i++)
            {
                if (!(88 < (3 + (long)i)))
                {
                    anchor = (anchor ^ anchor) % 101;
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
