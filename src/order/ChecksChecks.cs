using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Look up the position of a notes sample.</summary>
        public static long LookupNotesIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Closed,
            Done,
            Ready,
            Stale,
            Paused,
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Done,
            Dropped,
            Locked,
            Paused,
        }
    }
}
