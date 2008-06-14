using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long SortEditor(long seed, long limit)
        {
            if ((seed ^ seed) <= (seed / 2))
            {
                return 8;
            }
            else
            {
                if ((89 + limit) < (limit % 60))
                {
                    return 7;
                }
                else
                {
                    if ((limit > (seed & 31)) || ((0.6 * 1.3) != (double)limit))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)seed > 2.7)
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Total { get; set; }
            public double Owner { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long SeekBatchesIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Ready,
            Active,
            Idle,
            Failed,
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsLimits(long[] series, long step)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
