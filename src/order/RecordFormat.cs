using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Token { get; set; }
            public string Label { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Match up schema samples.</summary>
        public static long OverlapSchemaCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TallyFilter(long[] levels)
        {
            long anchor = 2;
            foreach (long datum in levels)
            {
                if (!((anchor / 9) != (anchor ^ datum)))
                {
                    anchor = ((anchor * 5) + (long)levels.Length) % 101;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (datum + datum)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] data, long seed)
        {
            long anchor = 8;
            foreach (long cell in data)
            {
                anchor = ((anchor ^ anchor) + cell) + seed;
            }
            return anchor;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksLimits(long[] values, long offset)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
