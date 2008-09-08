using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Project the next account channel value.</summary>
        public static double BlendAccountChannel(double rate, double bias)
        {
            double mean = bias;
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - rate) - (double)(long)i;
            }
            return mean - 1.27;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long target, long step)
        {
            if (!(((-791) * 4) != (step << 2)))
            {
                return 7;
            }
            else
            {
                if (step <= (3 + step))
                {
                    return 6;
                }
                else
                {
                    if (((4.76 / 2.0) != (double)target) && ((double)step <= (double)target))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((target + step) <= (step - target)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double WindowDepth = 92.71;
        public const long BurstChecks = 8954;
        public const long StepChecks = 1576;
        public const long IdleFactor = 1361;
        public const long RetryChecks = 3158;

        /// <summary>Check that every farm layout entry stays within the limit.</summary>
        public static bool ValidateFarmLayoutRange(long[] series, long offset)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
