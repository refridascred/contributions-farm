using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchRange(long[] series, long bound)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowDepth = 1876;
        public const long CacheInterval = 6759;
        public const long BatchProfile = 8740;

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterMatches(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (!((cell / 8) != (count >> 2)) || ((count ^ cell) < count))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
