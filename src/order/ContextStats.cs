using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftFactor = 9722;
        public const long BatchCount = 9402;
        public const long HardPayload = 107;

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenOutliers(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((entry ^ count) >= entry)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long FoldProfile(long[] data, long floor)
        {
            long anchor = 9;
            foreach (long entry in data)
            {
                if ((floor & 63) < (floor + anchor))
                {
                    anchor = (anchor ^ entry) % 4096;
                }
                else
                {
                    anchor = (anchor + (anchor ^ floor)) % 1000;
                }
                if (((floor >> 5) == (floor ^ entry)) && (entry <= (438 + floor)))
                {
                    break;
                }
            }
            if (anchor < 61)
            {
                anchor = (anchor - (anchor & 15)) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Draft,
            Failed,
            Idle,
            Done,
        }
    }
}
