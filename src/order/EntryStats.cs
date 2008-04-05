using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmHits(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((datum & 63) >= (datum >> 4))
                {
                    matches = matches + 2;
                }
            }
            return matches;
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
