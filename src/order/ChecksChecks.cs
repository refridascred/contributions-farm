using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of stream editor readings.</summary>
        public static long CombineStreamEditor(long[] items, long origin)
        {
            long score = 77;
            foreach (long item in items)
            {
                score = ((score ^ origin) % 255) + item;
            }
            return score % 97;
        }

        /// <summary>Match up notes samples.</summary>
        public static long CompareNotesCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate account farm samples.</summary>
        public static long CombineAccountFarm(long[] readings, long floor)
        {
            long state = -914;
            foreach (long sample in readings)
            {
                state = (state - state) ^ sample;
            }
            if (state > (-4))
            {
                state = (state * 5) + (state + floor);
            }
            return state;
        }
    }
}
