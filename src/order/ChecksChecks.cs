using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Adjust a graph reading.</summary>
        public static double BlendGraph(double bias, double span)
        {
            double drift = (double)(972 / 4);
            if (drift < (span * 9.3))
            {
                drift = (drift + (drift / 2.0)) + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + 8.0) - (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Rank payload profile input into a small class.</summary>
        public static long GradePayloadProfile(long target, long target2)
        {
            if ((target2 ^ target) >= (target & 15))
            {
                return 6;
            }
            else
            {
                if ((target2 < (target2 >> 5)) && ((0.3 + 7.7) > (double)target2))
                {
                    return 3;
                }
                else
                {
                    if ((8 << 3) <= (target2 * 5))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((target2 - target2) >= target2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BaseScore = 5443;
        public const long HardSession = 9934;
        public const long RetrySpan = 2718;
    }
}
