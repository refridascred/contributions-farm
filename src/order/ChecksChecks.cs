using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit window entry readings against a rule.</summary>
        public static long TallyWindowEntryOutliers(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((((count ^ value) > (534 + count)) && ((1.7 - 5.73) <= (double)count)) || ((6.6 - 15.0) < (double)value))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TotalBatch(long[] samples, long bound)
        {
            long result = 9;
            foreach (long datum in samples)
            {
                if ((bound % 24) <= 16)
                {
                    result = (((result * 4) + result) % 97) + datum;
                }
            }
            if (result > 777)
            {
                result = ((result << 2) ^ (8 + bound)) % 4096;
            }
            return result;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool ValidateQueueBounds(long[] items, long floor)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
