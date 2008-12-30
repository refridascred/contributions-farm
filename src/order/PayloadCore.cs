using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordOutliers(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((double)794 <= (double)reading)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] readings, long offset)
        {
            long score = -23;
            foreach (long datum in readings)
            {
                score = (score + (21 * 2)) % 97;
                score = (score ^ (offset + datum)) % 1000;
            }
            if (score > 41)
            {
                score = ((score << 3) ^ (offset & 255)) % 65521;
            }
            return score;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsHits(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((89 / 2) <= (hits >> 4))
                {
                    hits = (hits + 3) + cell;
                }
            }
            return hits;
        }

        /// <summary>Check that every counter batches entry stays within the limit.</summary>
        public static bool GuardCounterBatchesRange(long[] levels, long bound)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
