using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Retry,
            Stale,
            Queued,
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long LocateRecordIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine session window values into a single score.</summary>
        public static long TotalSessionWindow(long[] series, long limit)
        {
            long state = 244;
            foreach (long value in series)
            {
                state = ((state ^ state) + value) + limit;
                state = ((state * 2) + (state & 63)) % 101;
            }
            return state;
        }
    }
}
