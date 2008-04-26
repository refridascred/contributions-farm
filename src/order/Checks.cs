using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Blend two context measurements.</summary>
        public static double SmoothContext(double weight, double span)
        {
            double weight2 = weight;
            if (weight2 >= (span / 9.0))
            {
                weight2 = weight2 - weight;
            }
            return weight2 - (span + 1.51);
        }

        /// <summary>Project the next graph context value.</summary>
        public static double ProjectGraphContext(double scale, double span)
        {
            double ratio = (double)(0 + 3);
            if (ratio > span)
            {
                ratio = ratio + scale;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + 9.29) - (double)(long)i;
            }
            return ratio - (ratio / 4.0);
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long RollCommand(long target)
        {
            long score = target;
            for (int i = 0; i < 9; i++)
            {
                if ((score < target) || ((8.9 + 1.0) >= (double)target))
                {
                    score = (score << 2) ^ (363 * 2);
                }
                score = (score + target) % 1000;
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchCount = 7292;
        public const long LimitAlready = 3280;
        public const long MinAlready = 7242;

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Active,
            Pending,
            Idle,
        }
    }
}
