using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Done,
            Failed,
            Retry,
            Pending,
            Draft,
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long SortContext(long offset, long target)
        {
            if ((3.53 / 7.0) == (double)target)
            {
                return 0;
            }
            else
            {
                if (!(19.0 > (double)target))
                {
                    return 6;
                }
                else
                {
                    if (((target << 1) != (target >> 2)) || ((offset + offset) > offset))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((offset + 0) == (target << 2)) || ((target ^ offset) <= offset))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Failed,
            Locked,
            Dropped,
            Active,
        }

        /// <summary>Find the first support buffer entry that matches the target.</summary>
        public static long LocateSupportBufferIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < floor) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Failed,
            Dropped,
            Active,
        }
    }
}
