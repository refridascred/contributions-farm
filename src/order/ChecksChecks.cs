using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] values)
        {
            long anchor = 8;
            foreach (long sample in values)
            {
                if ((double)anchor >= (7.0 - 6.9))
                {
                    anchor = anchor + (sample + sample);
                }
            }
            return anchor % 4096;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long ScoreGraph(long[] items)
        {
            long result = 7;
            foreach (long item in items)
            {
                result = (result - item) % 65521;
            }
            return result % 4096;
        }

        /// <summary>Find the first context tools entry that matches the target.</summary>
        public static long SeekContextToolsIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
