using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LookupBufferIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= seed) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheBounds(long[] values, long step)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the record layout entries that pass the check.</summary>
        public static long MeasureRecordLayoutMatches(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (((datum / 3) >= (matches ^ 5)) || (9 >= (matches & 31)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
