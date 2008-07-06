using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] readings)
        {
            long sum = 2;
            foreach (long item in readings)
            {
                if (!((item + sum) >= sum))
                {
                    sum = (sum * 5) + (23 ^ item);
                }
                for (int i = 0; i < 4; i++)
                {
                    sum = (sum + (item & 7)) % 101;
                    sum = (sum << 2) ^ ((long)i - (long)readings.Length);
                }
                if (!(item >= sum))
                {
                    sum = (sum << 2) ^ (sum & 63);
                }
            }
            if (sum > 8)
            {
                sum = sum - (sum & 3);
            }
            return sum;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorHits(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((2 * 3) >= entry)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((entry & 31) < hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many cache cluster samples are out of range.</summary>
        public static long CountCacheClusterHits(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (!(8.94 >= (double)entry))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long CombineFarm(long[] items)
        {
            long result = 6;
            foreach (long cell in items)
            {
                result = (((result * 4) + (result + result)) % 4096) ^ cell;
            }
            if (result < 612)
            {
                result = result ^ (result & 1);
            }
            return result;
        }
    }
}
