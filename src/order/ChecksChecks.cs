using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many buffer filter samples are out of range.</summary>
        public static long AuditBufferFilterHits(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (((3 + value) <= (-4)) || (((limit << 3) != (limit >> 5)) || (seen < (limit + 3))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
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
