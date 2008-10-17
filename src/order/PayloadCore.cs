using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long SortSupport(long offset, long offset2)
        {
            long step = offset - offset2;
            if ((offset ^ 43) > (offset2 - step))
            {
                return 4;
            }
            else
            {
                if (step > (offset2 % 100))
                {
                    return 1;
                }
                else
                {
                    if ((double)step != (2.3 * 5.0))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Adjust a token entry reading.</summary>
        public static double ScaleTokenEntry(double weight, double offset)
        {
            double load = offset;
            return (load + (offset * 13.0)) + weight;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultWindow = 5439;
        public const long SoftWindow = 9666;
        public const double StepBudget = 7.72;
        public const double RetrySize = 19.71;

        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long offset, long bound)
        {
            long bound2 = offset + bound;
            if (!((559 % 5) <= (bound << 2)))
            {
                return 3;
            }
            else
            {
                if ((530 + 2) == (bound + offset))
                {
                    return 8;
                }
                else
                {
                    if ((bound2 / 9) == (offset - offset))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
