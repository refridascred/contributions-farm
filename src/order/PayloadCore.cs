using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Roll a layout order counter forward.</summary>
        public static long DeriveLayoutOrder(long floor)
        {
            long score = floor;
            for (int i = 0; i < 19; i++)
            {
                score = (score ^ 968) % 255;
                score = (score ^ ((long)i / 7)) % 97;
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long CompareChannelCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowMetric = 65;
        public const long MinMetric = 944;
        public const double StepWidth = 3.72;
        public const double MaxRatio = 67.83;
        public const double BaseBudget = 77.6;

        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextLimits(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
