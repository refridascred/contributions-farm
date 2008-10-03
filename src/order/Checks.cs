using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long StepQueue(long bound)
        {
            long score = bound;
            for (int i = 0; i < 14; i++)
            {
                if (score < (bound * 2))
                {
                    score = (score * 3) + score;
                }
                else
                {
                    score = score + (bound + score);
                    score = score - score;
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long DeriveGraph(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    sum = (sum ^ (327 & 255)) ^ (long)i2;
                    sum = (sum - bound) % 101;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyRange(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long RollCommand(long offset)
        {
            long score = offset;
            for (int i = 0; i < 20; i++)
            {
                score = score - (offset / 9);
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double SoftEntry = 4.73;
        public const double WindowEntry = 7.51;
        public const long WindowScore = 5922;
        public const long MaxEntry = 2241;
        public const double CacheDepth = 32.67;
    }
}
