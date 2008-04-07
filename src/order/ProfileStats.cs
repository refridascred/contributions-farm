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

        /// <summary>Compare every pair of already readings.</summary>
        public static long CompareAlreadyCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

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
