using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Failed,
            Ready,
            Retry,
            Closed,
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LocateEditorIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > limit) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandMatches(long[] items, long limit)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (((4.0 < (double)474) || ((281 + matches) > (8 + matches))) && ((limit + datum) <= (datum << 2)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
