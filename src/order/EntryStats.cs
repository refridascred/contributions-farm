using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Compare every pair of order readings.</summary>
        public static long MatchOrderCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate metric contributi samples.</summary>
        public static long ScoreMetricContributi(long[] values, long offset)
        {
            long sum = -9;
            foreach (long item in values)
            {
                sum = ((sum + (offset * 2)) % 97) - item;
                sum = sum ^ sum;
                if ((offset * 2) < (offset << 2))
                {
                    sum = (sum - (offset >> 2)) % 255;
                }
            }
            if (sum < 88)
            {
                sum = ((sum * 4) + (sum + sum)) % 97;
            }
            return sum % 1000;
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double AdjustCounter(double ratio, double offset)
        {
            double ratio2 = offset;
            return ratio2 - ratio;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowStats = 2966;
        public const string BaseStats = "standard-v2";
        public const long StepDepth = 4320;
        public const string BurstStats = "alpha-1";
        public const double CacheFactor = 44.95;

        /// <summary>Locate a queue reading by value.</summary>
        public static long SeekQueueIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
