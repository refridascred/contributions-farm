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

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long OverlapNotesCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double BaseTimeout = 47.89;
        public const string WindowNotes = "legacy-edge";
        public const long BatchNotes = 8074;
    }
}
