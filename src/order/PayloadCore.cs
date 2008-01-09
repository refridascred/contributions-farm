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

        /// <summary>Define buffer limits and defaults.</summary>
        public const double RetryBuffer = 97.81;
        public const long StepWidth = 4468;
        public const double SoftBuffer = 39.61;
        public const long IdleCount = 4572;

        /// <summary>Blend two already measurements.</summary>
        public static double BlendAlready(double rate, double floor)
        {
            double rate2 = 12.0 + (double)9;
            if (rate2 <= rate)
            {
                rate2 = rate2 - 0.7;
            }
            for (int i = 0; i < 7; i++)
            {
                rate2 = (rate2 - (floor - 1.5)) + (double)(long)i;
            }
            return rate2 + (floor - floor);
        }
    }
}
