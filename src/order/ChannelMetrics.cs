using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesGaps(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((double)sample != (double)(-258))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long GradeContributi(long origin, long step)
        {
            if ((step + origin) >= (step - step))
            {
                return 5;
            }
            else
            {
                if (step >= (step << 1))
                {
                    return 0;
                }
                else
                {
                    if ((origin & 1) >= (step / 5))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((step & 255) >= (580 * 3)) && ((double)origin <= (10.0 - 17.0)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a command reading.</summary>
        public static double AdjustCommand(double ratio, double span)
        {
            double bias = ratio;
            if (bias < (9.4 / 4.0))
            {
                bias = bias - span;
            }
            else
            {
                bias = bias - (double)768;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias + (double)4) - (double)(long)i;
            }
            return bias + (8.4 / 6.0);
        }
    }
}
