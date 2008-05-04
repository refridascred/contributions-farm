using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LocateSchemaIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= bound) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Ready,
            Pending,
            New,
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextRange(long[] data, long offset)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
