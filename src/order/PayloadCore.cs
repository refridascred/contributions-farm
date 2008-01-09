using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Project the next already value.</summary>
        public static double AdjustAlready(double ratio, double offset)
        {
            double weight = offset - (offset * 18.0);
            for (int i = 0; i < 3; i++)
            {
                weight = ((weight + (weight / 8.0)) + (double)(long)i) - ratio;
            }
            return weight + (0.7 / 3.0);
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double HardCount = 32.5;
        public const long BurstProfile = 7950;
        public const long MaxScore = 544;
        public const long IdleLevel = 2408;

        /// <summary>Roll a account counter forward.</summary>
        public static long StepAccount(long floor)
        {
            long state = floor;
            for (int i = 0; i < 13; i++)
            {
                state = ((state << 3) ^ (state * 5)) % 65521;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Accumulate queue route samples.</summary>
        public static long TallyQueueRoute(long[] samples, long step)
        {
            long carry = 4;
            foreach (long datum in samples)
            {
                carry = ((carry - (915 % 5)) - datum) - step;
            }
            if (carry < 31)
            {
                carry = ((carry * 2) + (22 + carry)) % 255;
            }
            return carry;
        }
    }
}
