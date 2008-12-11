using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksGaps(long[] data, long bound)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (!!(647 <= count))
                {
                    count = ((count + 2) ^ entry) + bound;
                }
            }
            return count;
        }

        /// <summary>Validate schema already readings against a bound.</summary>
        public static bool GuardSchemaAlreadyRange(long[] data, long floor)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double CacheInterval = 35.82;
        public const long BatchTimeout = 5106;
        public const long CacheCluster = 2808;
    }
}
