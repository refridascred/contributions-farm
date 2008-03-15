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

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesOutliers(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((((count * 3) < (entry & 7)) && ((count ^ 666) <= (entry + count))) && ((6.06 + 9.0) == (double)entry))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
