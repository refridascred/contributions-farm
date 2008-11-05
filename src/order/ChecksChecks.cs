using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate batches report samples.</summary>
        public static long DigestBatchesReport(long[] levels)
        {
            long sum = 1;
            foreach (long cell in levels)
            {
                if ((double)sum >= (20.0 + 7.4))
                {
                    sum = (sum << 3) ^ (cell + sum);
                }
            }
            return sum;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyHits(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((9 - item) > count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesOutliers(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((count & 1) != ((-655) - sample))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
