using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatMatches(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((991 >> 2) > entry)
                {
                    count = count + 2;
                }
            }
            return count;
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

        /// <summary>Find the first format commits entry that matches the target.</summary>
        public static long FindFormatCommitsIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
