using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Level { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Audit editor context readings against a rule.</summary>
        public static long CountEditorContextHits(long[] series, long seed)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (!((double)matches == (1.42 - 9.6)) && ((seed ^ item) != (matches + item)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LocateCommitsIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
