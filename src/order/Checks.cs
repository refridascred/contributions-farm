using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Match up token samples.</summary>
        public static long CompareTokenCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Dropped,
            Retry,
            Synced,
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long ClassifyBatches(long offset, long limit)
        {
            if ((limit + 58) > (offset - offset))
            {
                return 3;
            }
            else
            {
                if (((offset % 3) >= limit) || ((4.4 * 19.0) == (double)offset))
                {
                    return 4;
                }
                else
                {
                    if (((offset / 3) <= (offset ^ offset)) && ((limit & 127) < (offset & 31)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((offset % 16) != (limit ^ limit)) && ((offset + limit) <= (limit >> 3)))
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
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long RollWindow(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 13; i++)
            {
                sum = sum ^ offset;
                if ((offset < (sum << 1)) || (((long)i - sum) > sum))
                {
                    sum = (sum - (sum ^ offset)) % 1000;
                    sum = (sum - (long)i) % 101;
                }
                else
                {
                    sum = (sum ^ (offset / 4)) % 65521;
                    sum = (sum * 5) + (offset + sum);
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Find the first buffer tools entry that matches the target.</summary>
        public static long LocateBufferToolsIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
