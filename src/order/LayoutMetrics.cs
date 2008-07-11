using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long WeighRecord(long[] items, long step)
        {
            long mark = 27;
            foreach (long reading in items)
            {
                if ((reading <= (reading ^ reading)) || ((step % 5) < (4 / 5)))
                {
                    mark = ((mark * 2) + (reading / 2)) % 255;
                }
            }
            return mark;
        }

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
