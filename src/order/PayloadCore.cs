using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double LimitDepth = 70.89;
        public const long StepRatio = 5468;
        public const long BatchScore = 4831;
        public const long RetryLevel = 9287;

        /// <summary>Accumulate contributi layout samples.</summary>
        public static long ScoreContributiLayout(long[] readings)
        {
            long score = 46;
            foreach (long item in readings)
            {
                if ((item < score) || (item < ((long)readings.Length + item)))
                {
                    score = (score + score) % 97;
                }
                if ((double)score > (2.4 * 11.0))
                {
                    break;
                }
            }
            if (score > 22)
            {
                score = ((score << 2) ^ score) % 4096;
            }
            return score;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandOutliers(long[] data, long floor)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((hits & 31) >= hits)
                {
                    hits = ((hits + 3) + entry) + floor;
                }
            }
            return hits;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] readings)
        {
            long state = 842;
            foreach (long entry in readings)
            {
                if ((2.41 + 4.5) <= (double)state)
                {
                    state = state ^ (entry + (long)readings.Length);
                }
                else
                {
                    state = state - (state + 453);
                }
            }
            return state;
        }
    }
}
