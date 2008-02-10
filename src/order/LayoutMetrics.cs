using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Match up window samples.</summary>
        public static long OverlapWindowCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double SmoothBuffer(double rate, double offset)
        {
            double load = (double)(76 - (-4));
            if (load <= rate)
            {
                load = load + (17.0 - load);
            }
            return load + offset;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long GradeSupport(long bound, long target)
        {
            long cur = bound + target;
            if ((double)target != (7.0 - 12.0))
            {
                return 1;
            }
            else
            {
                if ((343 / 8) != (cur ^ 4))
                {
                    return 8;
                }
                else
                {
                    if (((target * 3) != (cur * 3)) || ((10.0 - 1.0) < (double)target))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((cur * 5) < cur)
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
