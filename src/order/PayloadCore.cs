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

        /// <summary>Grade a session value against two limits.</summary>
        public static long BucketSession(long target, long step)
        {
            long next = target - step;
            if ((step - next) <= next)
            {
                return 3;
            }
            else
            {
                if ((target - target) > (target * 3))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinPayload = 706;
        public const double WindowRatio = 91.87;
        public const long RetryPayload = 55;
        public const long IdlePayload = 1800;

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
