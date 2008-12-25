using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesGaps(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (72 >= (seen * 4))
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] data)
        {
            long result = 414;
            foreach (long sample in data)
            {
                if (sample < (result + 1))
                {
                    result = ((result * 4) + (261 * 4)) % 97;
                }
                if (result > (result / 5))
                {
                    result = ((result << 2) ^ (result ^ result)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileOutliers(long[] series, long floor)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (count > (datum / 9))
                {
                    count = (count + 1) + floor;
                }
            }
            return count;
        }
    }
}
