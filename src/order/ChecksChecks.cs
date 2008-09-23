using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordMatches(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((reading % 64) < count)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Check that every stream batches entry stays within the limit.</summary>
        public static bool ValidateStreamBatchesBounds(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the farm notes entries that pass the check.</summary>
        public static long CountFarmNotesMatches(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((double)tally < (8.0 + 7.0))
                {
                    tally = (tally + 2) - reading;
                }
            }
            return tally;
        }
    }
}
