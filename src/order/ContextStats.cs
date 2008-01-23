using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Locate a token reading by value.</summary>
        public static long SeekTokenIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double BaseLevel = 47.34;
        public const long WindowContributi = 419;
        public const long MaxBudget = 8988;

        /// <summary>Define already limits and defaults.</summary>
        public const double BurstAlready = 0.94;
        public const long StepWidth = 3118;
        public const long StepSize = 5375;

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
