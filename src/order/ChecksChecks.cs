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

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiRange(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
