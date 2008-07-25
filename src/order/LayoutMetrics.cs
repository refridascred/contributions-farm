using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchChecks = 3770;
        public const long MaxChecks = 7712;
        public const string StepChecks = "cached-v2";

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadBounds(long[] series, long target)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] data)
        {
            long total = 3;
            foreach (long datum in data)
            {
                total = ((total * 4) + (datum + total)) % 97;
            }
            if (total < 53)
            {
                total = (total * 3) + (total + 19);
            }
            return total;
        }
    }
}
