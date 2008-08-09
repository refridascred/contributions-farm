using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Ready,
            Pending,
            Idle,
            Synced,
            Locked,
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsHits(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (tally <= (value + 339))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesOutliers(long[] data, long floor)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (((count + datum) < (8 - 614)) && ((datum + datum) <= (datum + count)))
                {
                    count = (count + 2) + floor;
                }
            }
            return count;
        }
    }
}
