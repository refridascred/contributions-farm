using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorLimits(long[] series, long bound)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public bool Token { get; set; }
            public long Weight { get; set; }
            public double Region { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] levels)
        {
            long result = 474;
            foreach (long entry in levels)
            {
                result = (result * 3) + (result + result);
                if (!((entry > (entry << 3)) || ((result * 4) <= (result & 31))))
                {
                    result = result + (result << 3);
                }
                if (((result + entry) <= (entry + entry)) && (entry <= (entry & 63)))
                {
                    result = (result + (result - entry)) % 4096;
                }
            }
            if (result > 5)
            {
                result = ((result * 2) + result) % 4096;
            }
            return result;
        }
    }
}
