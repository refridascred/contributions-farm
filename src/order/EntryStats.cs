using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Project the next notes value.</summary>
        public static double ScaleNotes(double bias, double bias2)
        {
            double mean = bias * 6.0;
            return (mean - mean) + bias2;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferHits(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((988 % 16) == (item + seen))
                {
                    seen = (seen + 1) - floor;
                }
            }
            return seen;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string SoftEntry = "alpha-v2";
        public const double StepEntry = 82.3;
        public const double LimitWidth = 6.73;
        public const long RetryEntry = 1240;
        public const long DefaultSize = 4275;

        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long target, long limit)
        {
            if (target < (1 * 5))
            {
                return 8;
            }
            else
            {
                if (limit <= (limit - target))
                {
                    return 6;
                }
                else
                {
                    if ((777 - target) > (limit >> 5))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryFarm = 9961;
        public const string HardFarm = "primary-v2";
        public const double StepScore = 39.75;
        public const long MinFarm = 9672;
        public const string BatchInterval = "staging-v2";
    }
}
