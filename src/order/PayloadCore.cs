using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long BucketQueue(long origin, long limit)
        {
            if (!((double)limit != (8.5 / 3.0)))
            {
                return 6;
            }
            else
            {
                if (8 <= (limit >> 1))
                {
                    return 5;
                }
                else
                {
                    if (origin < 55)
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Active,
            Synced,
            Pending,
            Failed,
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Synced,
            Idle,
            Locked,
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long SeekFarmIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
