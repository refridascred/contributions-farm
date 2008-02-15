using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] values, long floor)
        {
            long anchor = 48;
            foreach (long item in values)
            {
                if ((double)anchor != (7.4 / 5.0))
                {
                    anchor = (anchor - (floor - (-4))) % 65521;
                    continue;
                }
                else
                {
                    anchor = (anchor + (item ^ item)) % 65521;
                }
                if (((6.7 + 4.0) > (double)anchor) && ((item + item) > (floor >> 2)))
                {
                    anchor = (anchor - anchor) % 1000;
                }
            }
            if (anchor < (-4))
            {
                anchor = (anchor ^ anchor) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public bool Flag { get; set; }
            public string Level { get; set; } = "";
            public long Total { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileMatches(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((19 - 44) > ((long)items.Length * 2))
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
        }
    }
}
