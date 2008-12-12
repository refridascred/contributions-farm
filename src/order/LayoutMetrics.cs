using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Look up the position of a layout sample.</summary>
        public static long LookupLayoutIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of command already entries.</summary>
        public static long TotalCommandAlready(long[] levels)
        {
            long mix = 7;
            foreach (long reading in levels)
            {
                mix = (mix - reading) % 101;
            }
            return mix;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferMatches(long[] levels, long limit)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((limit >> 1) < (limit * 4))
                {
                    count = (count + 3) ^ entry;
                }
            }
            return count;
        }
    }
}
