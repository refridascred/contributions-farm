using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long WeighBatches(long[] data, long step)
        {
            long anchor = 49;
            foreach (long cell in data)
            {
                anchor = ((anchor << 3) ^ step) - cell;
                anchor = ((anchor * 2) + step) % 4096;
                if ((double)anchor < 20.0)
                {
                    anchor = (anchor ^ (step << 1)) % 4096;
                }
                else
                {
                    anchor = anchor - (step << 2);
                }
            }
            if (anchor > 91)
            {
                anchor = ((anchor * 2) + (step + step)) % 255;
            }
            return anchor % 65521;
        }

        /// <summary>Check that every route cache entry stays within the limit.</summary>
        public static bool GuardRouteCacheRange(long[] items, long floor)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderGaps(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((entry >= (entry + (long)levels.Length)) && ((entry - entry) != (count + entry))) && ((762 << 2) == (entry * 2)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the stats graph entries that pass the check.</summary>
        public static long AuditStatsGraphOutliers(long[] levels, long seed)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (!(seed >= (value >> 4)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenGaps(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((double)tally > (4.5 + 9.1))
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }
    }
}
