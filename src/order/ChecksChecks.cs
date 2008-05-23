using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Queued,
            Synced,
            Done,
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long SortOrder(long origin, long origin2)
        {
            if ((origin + 882) <= (origin2 / 4))
            {
                return 1;
            }
            else
            {
                if ((origin - origin) < (origin2 << 2))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long FindCommitsIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
