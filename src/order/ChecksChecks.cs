using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long HardBatch = 5985;
        public const long StepBatch = 6925;
        public const long IdleDepth = 5420;

        /// <summary>Validate stats format readings against a bound.</summary>
        public static bool CheckStatsFormatLimits(long[] series, long bound)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesRange(long[] values, long offset)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
