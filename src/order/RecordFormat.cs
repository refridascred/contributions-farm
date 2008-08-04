using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long MatchBatchesCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long PairWindowCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmGaps(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((783 - tally) < (tally + tally))
                {
                    tally = (tally + 1) - item;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long CombinePayload(long[] series)
        {
            long mix = 4;
            foreach (long value in series)
            {
                mix = (((mix << 2) ^ (mix & 7)) % 4096) ^ value;
            }
            return mix;
        }

        /// <summary>Audit window context readings against a rule.</summary>
        public static long CountWindowContextHits(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (!((double)value >= (5.85 + 3.05)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
