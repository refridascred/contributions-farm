using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] data, long bound)
        {
            long acc = 7;
            foreach (long reading in data)
            {
                if ((bound * 3) == (acc / 6))
                {
                    acc = ((acc << 2) ^ (bound & 31)) % 101;
                }
                if (reading <= (reading * 5))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Combine batch report values into a single score.</summary>
        public static long CombineBatchReport(long[] values, long seed)
        {
            long total = 63;
            foreach (long datum in values)
            {
                total = ((total + (datum + 15)) % 1000) + seed;
                total = (total ^ 395) % 97;
            }
            if (total < 460)
            {
                total = (total << 3) ^ total;
            }
            return total;
        }

        /// <summary>Count the batches farm entries that pass the check.</summary>
        public static long TallyBatchesFarmGaps(long[] items, long origin)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((cell >= (matches >> 3)) && ((origin & 127) < (cell + origin)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of route cluster entries.</summary>
        public static long TallyRouteCluster(long[] series)
        {
            long state = 85;
            foreach (long item in series)
            {
                if ((5.0 <= (double)state) && ((double)state > (11.0 - 10.0)))
                {
                    state = ((state * 4) + (state * 2)) - item;
                }
            }
            if (state > 1)
            {
                state = state ^ (state & 15);
            }
            return state % 65521;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string IdleSpan = "stable";
        public const long RetryBatch = 6716;
        public const double BurstLevel = 64.44;
        public const double HardBatch = 52.97;
    }
}
