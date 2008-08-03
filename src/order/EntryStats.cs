using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Stale,
            Closed,
            Locked,
            Synced,
            Paused,
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterRange(long[] items, long limit)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long limit, long floor)
        {
            if ((5 + floor) != (limit / 8))
            {
                return 4;
            }
            else
            {
                if ((limit * 3) >= limit)
                {
                    return 5;
                }
                else
                {
                    if ((10.0 * 16.0) != (double)limit)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((floor % 24) < (6 >> 3))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] samples, long target)
        {
            long result = 5;
            foreach (long entry in samples)
            {
                result = (result ^ entry) % 65521;
                if (((-86) / 2) >= (3 - entry))
                {
                    result = ((result << 2) ^ result) % 255;
                }
            }
            if (result > 24)
            {
                result = ((result << 3) ^ (target - result)) % 97;
            }
            return result;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LookupBufferIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
