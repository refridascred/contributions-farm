using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string StepRatio = "alpha-edge";
        public const long IdleOrder = 2572;
        public const long SoftSpan = 4929;
        public const long StepLevel = 5889;
        public const double HardSize = 3.84;

        /// <summary>Look up the position of a cache sample.</summary>
        public static long LocateCacheIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterGaps(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((949 - value) != (matches + 961))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long SeriesCounter(long target)
        {
            long result = target;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    result = (result + result) - (long)i2;
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Failed,
            New,
            Closed,
            Draft,
            Ready,
        }
    }
}
