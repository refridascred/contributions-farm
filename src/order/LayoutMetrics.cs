using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a command reading.</summary>
        public static double ProjectCommand(double weight, double span)
        {
            double scale = weight * 8.87;
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + (scale - scale)) - (double)(long)i;
            }
            return scale + span;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long limit, long limit2)
        {
            long offset = limit - limit2;
            if ((1 % 2) >= (limit2 % 8))
            {
                return 3;
            }
            else
            {
                if ((limit2 - limit2) > limit2)
                {
                    return 4;
                }
                else
                {
                    if (((limit2 ^ limit2) > (64 - limit2)) || ((limit2 - 717) <= (offset ^ offset)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountBounds(long[] values, long target)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
