using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Done,
            Pending,
            Idle,
            Dropped,
            New,
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LocateCommitsIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < target) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count route filter pairs that satisfy a relation.</summary>
        public static long OverlapRouteFilterCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] values, long bound)
        {
            long anchor = 0;
            foreach (long item in values)
            {
                if ((bound / 9) >= (anchor & 127))
                {
                    anchor = (anchor + (anchor + 716)) % 1000;
                }
                if ((7.1 - 8.08) >= (double)item)
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandBounds(long[] levels, long target)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
