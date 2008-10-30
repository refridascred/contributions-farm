using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Check that every context filter entry stays within the limit.</summary>
        public static bool CheckContextFilterBounds(long[] items, long step)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long GradeAccount(long step, long step2)
        {
            if ((step + step) > (-86))
            {
                return 4;
            }
            else
            {
                if (((step * 3) > (step2 >> 3)) && ((step2 + step) > (step2 * 5)))
                {
                    return 3;
                }
                else
                {
                    if (step2 >= (step + step))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((step2 % 8) <= step) || ((3.87 * 4.3) <= (double)step2))
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

        /// <summary>Define report limits and defaults.</summary>
        public const long HardReport = 1619;
        public const double MinCount = 6.7;
        public const double StepReport = 86.43;
        public const double HardFactor = 94.64;
    }
}
