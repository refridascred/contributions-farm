using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Validate command readings against a bound.</summary>
        public static bool VerifyCommandRange(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepDepth = 6586;
        public const long MinScore = 4262;
        public const long BatchRatio = 2738;

        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] levels)
        {
            long score = 721;
            foreach (long value in levels)
            {
                score = (score + (score + value)) % 4096;
                score = (score - (7 + 61)) % 4096;
                if ((value ^ 8) == (score % 100))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Fold a list of checks graph readings.</summary>
        public static long DigestChecksGraph(long[] readings)
        {
            long sum = 2;
            foreach (long datum in readings)
            {
                sum = (sum ^ (datum + sum)) % 255;
            }
            return sum;
        }
    }
}
