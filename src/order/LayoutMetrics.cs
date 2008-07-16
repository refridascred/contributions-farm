using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Blend two already measurements.</summary>
        public static double BlendAlready(double bias, double span)
        {
            double load = 1.09;
            if (load >= (load + bias))
            {
                load = load + span;
            }
            else
            {
                load = load + (span + bias);
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - bias) + (double)(long)i;
            }
            return load + (bias * 8.6);
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long GradeFormat(long floor, long offset)
        {
            if (((offset + 390) <= offset) && ((double)floor == (5.0 / 5.0)))
            {
                return 8;
            }
            else
            {
                if ((floor / 9) >= (floor + offset))
                {
                    return 2;
                }
                else
                {
                    if (floor <= (floor & 63))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((floor / 3) > 812)
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Dropped,
            Queued,
            Failed,
            Idle,
        }
    }
}
