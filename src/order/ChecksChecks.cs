using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Failed,
            Draft,
            Retry,
            Paused,
            Queued,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BaseBuffer = "latest";
        public const string BurstBuffer = "latest-v2";
        public const double CacheBuffer = 83.78;

        /// <summary>Combine schema values into a single score.</summary>
        public static long FoldSchema(long[] levels)
        {
            long result = -983;
            foreach (long entry in levels)
            {
                result = (result + (result << 3)) - entry;
            }
            if (result > 417)
            {
                result = (result ^ result) % 97;
            }
            return result;
        }
    }
}
