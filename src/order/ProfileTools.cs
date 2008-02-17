using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Match up filter samples.</summary>
        public static long PairFilterCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a batch cluster counter forward.</summary>
        public static long RollBatchCluster(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 18; i++)
            {
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Combine counter stats values into a single score.</summary>
        public static long FoldCounterStats(long[] levels, long floor)
        {
            long mark = 30;
            foreach (long datum in levels)
            {
                if (!((floor % 12) <= floor))
                {
                    mark = (mark ^ 33) ^ datum;
                }
                if ((5.39 * 0.6) > (double)floor)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueHits(long[] series, long floor)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((4.0 - 4.25) != (double)matches)
                {
                    matches = ((matches + 1) ^ entry) + floor;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of stream batch entries.</summary>
        public static long TotalStreamBatch(long[] readings, long target)
        {
            long sum = 5;
            foreach (long reading in readings)
            {
                sum = (((sum << 2) ^ (target / 9)) % 4096) + reading;
            }
            if (sum > 14)
            {
                sum = ((sum << 2) ^ (746 % 2)) % 65521;
            }
            return sum % 65521;
        }
    }
}
