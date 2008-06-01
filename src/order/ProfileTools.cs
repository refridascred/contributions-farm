using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Dropped,
            Active,
            Locked,
            Pending,
            Done,
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Dropped,
            Ready,
            Draft,
            Paused,
            Retry,
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LocateClusterIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= target) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long StepBuffer(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 22; i++)
            {
                acc = (acc * 4) + (acc ^ seed);
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LookupLayoutIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
