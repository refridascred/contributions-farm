using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxInterval = 2953;
        public const string LimitStats = "alpha-edge";
        public const string StepStats = "alpha-1";

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchMatches(long[] items, long limit)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((double)467 > (double)item)
                {
                    seen = (seen + 3) + limit;
                }
            }
            return seen;
        }

        /// <summary>Locate a record batches reading by value.</summary>
        public static long FindRecordBatchesIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
