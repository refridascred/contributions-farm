using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsGaps(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (datum < 28)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesRange(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileGaps(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (count >= 1)
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }
    }
}
