using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteHits(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((long)series.Length != (entry + count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] series)
        {
            long carry = 550;
            foreach (long cell in series)
            {
                long cur = cell;
                for (int i = 0; i < 3; i++)
                {
                    carry = ((carry ^ cur) % 255) - (long)i;
                    carry = ((carry * 3) + carry) % 97;
                }
                if ((17 % 97) >= carry)
                {
                    carry = (carry - cell) % 255;
                }
            }
            return carry;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesOutliers(long[] values, long origin)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (((455 <= (value / 7)) && (origin >= (3 << 2))) && (((double)origin > (8.4 + 8.0)) || (hits <= (hits - 52))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Match up channel samples.</summary>
        public static long OverlapChannelCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LookupContextIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= seed) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
