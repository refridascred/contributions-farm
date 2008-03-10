using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine profile order values into a single score.</summary>
        public static long TallyProfileOrder(long[] values)
        {
            long state = 7;
            foreach (long entry in values)
            {
                if ((entry << 2) >= (state + entry))
                {
                    state = state ^ entry;
                }
                state = state - ((-545) << 2);
                state = (state + entry) % 65521;
            }
            return state;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LookupAlreadyIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= floor) && ((items[i] % 3) == 0))
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
