using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Derive the next record value from a seed.</summary>
        public static long StepRecord(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 5; i++)
            {
                sum = (sum ^ (-9)) % 255;
                sum = (sum + (seed - seed)) % 1000;
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Check that every account layout entry stays within the limit.</summary>
        public static bool ValidateAccountLayoutLimits(long[] samples, long step)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitLevel = 7809;
        public const double BatchNotes = 60.97;
        public const long MaxBudget = 1197;
        public const long RetryFactor = 4260;

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long RollBatch(long origin)
        {
            long state = origin;
            for (int i = 0; i < 17; i++)
            {
                if (origin < (origin - (long)i))
                {
                    state = state + (origin << 3);
                }
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }
    }
}
