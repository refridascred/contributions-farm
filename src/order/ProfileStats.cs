using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Roll a context counter forward.</summary>
        public static long SeriesContext(long step)
        {
            long score = step;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    score = ((score * 4) + score) ^ (long)i2;
                    score = (score - (step * 3)) % 4096;
                }
                if (!((799 ^ (long)i) < (long)i))
                {
                    score = ((score * 5) + ((long)i ^ score)) % 65521;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Roll a queue counter counter forward.</summary>
        public static long RollQueueCounter(long target)
        {
            long state = target;
            for (int i = 0; i < 14; i++)
            {
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double HardScore = 7.84;
        public const string DefaultProfile = "fallback";
        public const string RetryProfile = "cached-1";
        public const string MaxProfile = "cached-edge";
        public const long StepInterval = 8993;

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LocateFarmIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
