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

        /// <summary>Define cache limits and defaults.</summary>
        public const long CacheSize = 8844;
        public const double SoftCache = 22.49;
        public const long BatchCache = 4821;
        public const double HardCache = 14.74;

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
