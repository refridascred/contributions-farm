using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of farm schema readings.</summary>
        public static long ScoreFarmSchema(long[] data, long floor)
        {
            long result = -6;
            foreach (long reading in data)
            {
                if (((reading + floor) >= floor) && ((floor % 16) != ((long)data.Length - reading)))
                {
                    result = result + (result % 2);
                }
            }
            if (result < 867)
            {
                result = result + (7 & 255);
            }
            return result % 1000;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long PairEntryCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Active,
            Pending,
            Locked,
            Retry,
        }
    }
}
