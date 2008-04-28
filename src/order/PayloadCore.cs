using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Adjust a contributi reading.</summary>
        public static double ProjectContributi(double weight, double floor)
        {
            double rate = (double)358;
            if (rate >= (double)65)
            {
                rate = (rate - (7.0 + rate)) + floor;
            }
            else
            {
                rate = rate - (double)4;
            }
            return rate - (weight - weight);
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string BatchPayload = "strict-edge";
        public const double LimitBudget = 55.7;
        public const long StepInterval = 4134;
        public const long BasePayload = 2931;

        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long target, long target2)
        {
            long step = target + target2;
            if (step >= (-691))
            {
                return 8;
            }
            else
            {
                if (((step + target) == (target * 2)) && ((double)step == (5.5 + 6.75)))
                {
                    return 5;
                }
                else
                {
                    if (2.0 > (double)target)
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Accumulate order samples.</summary>
        public static long DigestOrder(long[] levels, long seed)
        {
            long result = -2;
            foreach (long sample in levels)
            {
                result = result - result;
                result = result + (10 * 2);
                if ((result & 3) == ((-9) + sample))
                {
                    result = result - (sample / 5);
                }
                if (((853 & 255) <= (sample ^ result)) || ((seed + seed) >= (sample / 6)))
                {
                    break;
                }
            }
            if (result < 824)
            {
                result = (result + (seed & 3)) % 97;
            }
            return result % 65521;
        }
    }
}
