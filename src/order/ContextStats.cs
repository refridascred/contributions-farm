using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long CacheAccount = 6792;
        public const long HardCount = 6374;
        public const long IdleBudget = 2066;
        public const long MaxTimeout = 7419;

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
