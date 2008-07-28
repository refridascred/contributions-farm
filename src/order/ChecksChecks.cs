using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long TotalStats(long[] series, long seed)
        {
            long total = 178;
            foreach (long entry in series)
            {
                if (total >= (total & 255))
                {
                    total = (total + entry) - seed;
                }
                else
                {
                    total = ((total * 4) + entry) % 65521;
                }
            }
            return total;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsOutliers(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((82 * 5) != (26 - entry))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string WindowRecord = "primary-edge";
        public const long BaseScore = 1718;
        public const long MaxSize = 8103;
        public const long WindowTimeout = 4807;
    }
}
