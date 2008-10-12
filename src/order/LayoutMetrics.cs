using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Failed,
            Active,
            Ready,
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmBounds(long[] items, long offset)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the route filter entries that pass the check.</summary>
        public static long MeasureRouteFilterHits(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((cell + 46) > (cell << 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
