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

        /// <summary>Project the next record value.</summary>
        public static double AdjustRecord(double bias, double offset)
        {
            double mean = (double)(76 * 5);
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + (bias - offset)) + (double)(long)i;
            }
            return mean + (double)44;
        }
    }
}
