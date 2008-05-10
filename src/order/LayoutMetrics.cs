using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate account stream readings against a bound.</summary>
        public static bool CheckAccountStreamBounds(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheBudget = 2420;
        public const long MinSchema = 1310;
        public const string BatchSchema = "staging";

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsOutliers(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (((long)data.Length / 8) > (hits + value))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
