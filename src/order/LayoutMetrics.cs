using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamLimits(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Total { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Count the report layout entries that pass the check.</summary>
        public static long TallyReportLayoutHits(long[] values, long origin)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (!((double)hits <= (double)origin))
                {
                    hits = (hits + 1) ^ sample;
                }
            }
            return hits;
        }
    }
}
