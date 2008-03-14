using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Active,
            Failed,
            Retry,
            Pending,
            Closed,
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Locked,
            Closed,
            Retry,
            Active,
            Synced,
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long step, long origin)
        {
            if ((origin - step) >= (step / 7))
            {
                return 0;
            }
            else
            {
                if ((origin % 100) <= (origin + origin))
                {
                    return 4;
                }
                else
                {
                    if (1.15 > (double)step)
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long SeekBatchesIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= step) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
