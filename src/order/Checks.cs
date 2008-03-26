using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Retry,
            Active,
            Ready,
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Done,
            Retry,
            Pending,
            New,
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long FindCounterIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyHits(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((double)entry < 2.0)
                {
                    matches = (matches + 2) + floor;
                }
            }
            return matches;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Stale,
            Retry,
            Pending,
            Dropped,
            Paused,
        }
    }
}
