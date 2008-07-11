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

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextOutliers(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((double)sample < 15.0)
                {
                    seen = seen + 2;
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
