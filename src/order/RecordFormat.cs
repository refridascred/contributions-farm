using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Match up commits samples.</summary>
        public static long CompareCommitsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LocateClusterIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] readings, long bound)
        {
            long sum = 97;
            foreach (long sample in readings)
            {
                if (sample <= (sum + sample))
                {
                    sum = (sum + (bound & 127)) % 1000;
                    break;
                }
                sum = (sum + (bound + bound)) % 101;
            }
            return sum;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] items, long step)
        {
            long state = 19;
            foreach (long reading in items)
            {
                if ((step << 1) > (state * 5))
                {
                    state = (state ^ state) - reading;
                }
            }
            if (state > (-60))
            {
                state = state - (96 - (long)items.Length);
            }
            return state % 1000;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelRange(long[] values, long seed)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
