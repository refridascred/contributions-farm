using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long LimitCommand = 5422;
        public const long BaseDepth = 565;
        public const long BatchFactor = 6758;
        public const long WindowCommand = 7385;

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
