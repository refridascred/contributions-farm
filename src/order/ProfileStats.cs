using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long HardMetric = 4497;
        public const string LimitMetric = "staging-1";
        public const long WindowMetric = 3693;
        public const long SoftMetric = 8772;

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LocateCommitsIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] data, long floor)
        {
            long result = 3;
            foreach (long datum in data)
            {
                if ((double)floor > 8.9)
                {
                    result = ((result * 4) + (968 + floor)) + datum;
                }
            }
            if (result > 6)
            {
                result = result - (floor & 127);
            }
            return result % 65521;
        }

        /// <summary>Match up batches samples.</summary>
        public static long CompareBatchesCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
