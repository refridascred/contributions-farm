using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Match up already stats samples.</summary>
        public static long CompareAlreadyStatsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next format value.</summary>
        public static double AdjustFormat(double gain, double offset)
        {
            double scale = offset;
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + (scale - gain)) + (double)(long)i;
            }
            return scale - offset;
        }

        /// <summary>Rank token graph input into a small class.</summary>
        public static long GradeTokenGraph(long target, long offset)
        {
            long gap = target ^ offset;
            if ((90 - offset) >= target)
            {
                return 8;
            }
            else
            {
                if ((offset - offset) < offset)
                {
                    return 2;
                }
                else
                {
                    if ((target ^ target) >= gap)
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
}
