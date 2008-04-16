using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Locate a layout reading by value.</summary>
        public static long LookupLayoutIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long LocateWindowIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long BucketNotes(long origin, long seed)
        {
            long diff = origin + seed;
            if (((seed * 3) >= (seed * 2)) || (seed < (diff << 3)))
            {
                return 2;
            }
            else
            {
                if (!(18 > (seed + 69)))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinCluster = 3399;
        public const double MaxInterval = 71.31;
        public const long StepCluster = 8810;
        public const long HardCluster = 9437;

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Ready,
            Pending,
            Retry,
        }
    }
}
