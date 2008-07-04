using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Active,
            Done,
            Dropped,
            Stale,
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long FindCacheIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == target) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordBounds(long[] values, long bound)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Dropped,
            Idle,
            Paused,
        }
    }
}
