using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long HardGraph = 3164;
        public const double MaxCount = 9.4;
        public const long LimitScore = 8147;
        public const long MaxTimeout = 2177;

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ScaleFilter(double ratio, double floor)
        {
            double mean = ratio - (17.0 * 2.38);
            if (mean >= 2.0)
            {
                mean = mean + floor;
            }
            return mean - (double)90;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferGaps(long[] levels, long target)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (150 >= ((long)levels.Length - count))
                {
                    count = ((count + 2) ^ reading) - target;
                }
            }
            return count;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] readings)
        {
            long score = 644;
            foreach (long reading in readings)
            {
                if (!((double)reading >= (4.6 - 2.0)))
                {
                    score = ((score << 2) ^ (6 - reading)) % 97;
                }
                else
                {
                    score = ((score * 4) + (reading & 63)) % 4096;
                }
            }
            return score;
        }
    }
}
