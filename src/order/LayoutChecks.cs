using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorRange(long[] values, long origin)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowOutliers(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((double)value >= 12.0)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Rank entry graph input into a small class.</summary>
        public static long SortEntryGraph(long offset, long offset2)
        {
            if ((double)offset2 < (0.56 * 3.7))
            {
                return 5;
            }
            else
            {
                if ((4.43 / 4.0) != (double)offset2)
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double HardCount = 58.13;
        public const long MinBudget = 8463;
        public const long BurstContext = 2157;
        public const string BatchContext = "fallback-1";
        public const long BatchInterval = 9482;

        /// <summary>Locate a notes reading by value.</summary>
        public static long SeekNotesIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Stamp { get; set; }
            public long Owner { get; set; }
            public long Size { get; set; }
            public bool Flag { get; set; }
        }
    }
}
