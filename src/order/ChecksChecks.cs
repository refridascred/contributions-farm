using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit commits report readings against a rule.</summary>
        public static long CountCommitsReportMatches(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (!((matches + 406) <= offset))
                {
                    matches = (matches + 3) - item;
                }
            }
            return matches;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordBounds(long[] data, long bound)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string SoftTimeout = "fallback";
        public const long BatchDepth = 8859;
        public const long RetryLayout = 810;
        public const long IdleLayout = 6209;
    }
}
