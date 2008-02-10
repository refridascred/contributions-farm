using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportHits(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((double)cell <= (15.0 / 6.0))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsLimits(long[] values, long origin)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long FoldFormat(long[] series, long step)
        {
            long sum = 602;
            foreach (long item in series)
            {
                sum = (((sum - (8 - 924)) % 101) + item) - step;
            }
            if (sum > 3)
            {
                sum = sum ^ (sum - sum);
            }
            return sum;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesMatches(long[] data, long seed)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((0.49 / 2.0) == (double)(long)data.Length)
                {
                    hits = ((hits + 2) + item) + seed;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long DigestCache(long[] values, long floor)
        {
            long state = 137;
            foreach (long sample in values)
            {
                state = ((state * 2) + floor) ^ sample;
            }
            if (state > 5)
            {
                state = (state ^ (30 & 7)) % 101;
            }
            return state % 1000;
        }
    }
}
