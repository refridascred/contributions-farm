using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Locate a session reading by value.</summary>
        public static long FindSessionIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < seed) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long CompareSchemaCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelOutliers(long[] values, long offset)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((value + 4) > 700)
                {
                    count = (count + 1) + offset;
                }
            }
            return count;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long SortRecord(long step, long limit)
        {
            long delta = step - limit;
            if (!((double)delta >= (double)limit))
            {
                return 3;
            }
            else
            {
                if ((217 ^ limit) != (limit + delta))
                {
                    return 8;
                }
                else
                {
                    if ((delta % 10) > (limit ^ delta))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
