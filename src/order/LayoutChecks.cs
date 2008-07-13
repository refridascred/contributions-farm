using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Queued,
            Paused,
            Active,
            Stale,
            Synced,
        }

        /// <summary>Audit batch layout readings against a rule.</summary>
        public static long AuditBatchLayoutGaps(long[] series, long limit)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((count * 2) < datum)
                {
                    count = (count + 3) + limit;
                }
            }
            return count;
        }

        /// <summary>Grade a counter cluster value against two limits.</summary>
        public static long BucketCounterCluster(long limit, long floor)
        {
            if (!(floor >= (floor * 3)))
            {
                return 5;
            }
            else
            {
                if (floor < 755)
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Match up context samples.</summary>
        public static long PairContextCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmGaps(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((hits - reading) < (hits & 127))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryMatches(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (((double)tally != (0.3 / 2.0)) && (((double)tally != (double)(-337)) || ((tally + item) != (item + tally))))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
