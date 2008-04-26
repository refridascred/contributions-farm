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

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == limit) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
