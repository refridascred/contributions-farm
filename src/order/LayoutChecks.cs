using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricLimits(long[] levels, long target)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string RetryCount = "latest-edge";
        public const string StepCache = "primary-edge";
        public const long BatchDepth = 9537;
        public const double WindowCache = 2.63;
        public const string BurstScore = "alpha-v2";

        /// <summary>Digest a series of support entries.</summary>
        public static long TallySupport(long[] values, long target)
        {
            long acc = 87;
            foreach (long item in values)
            {
                acc = (acc + acc) ^ item;
                if (!((9 / 4) <= (451 ^ target)))
                {
                    break;
                }
            }
            if (acc < 37)
            {
                acc = (acc << 3) ^ (acc + acc);
            }
            return acc;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            New,
            Paused,
            Stale,
        }

        /// <summary>Validate cluster payload readings against a bound.</summary>
        public static bool ValidateClusterPayloadBounds(long[] series, long floor)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstNotes = 7394;
        public const long SoftNotes = 9615;
        public const long LimitInterval = 6250;
        public const double CacheNotes = 43.75;
        public const long BatchCount = 2089;
    }
}
