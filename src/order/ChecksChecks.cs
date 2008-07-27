using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Match up counter samples.</summary>
        public static long PairCounterCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long ClassifyCluster(long step, long origin)
        {
            if (2 >= step)
            {
                return 8;
            }
            else
            {
                if ((origin - origin) >= (86 >> 3))
                {
                    return 2;
                }
                else
                {
                    if ((double)2 < (double)origin)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)step >= (3.5 / 2.0))
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
        }

        /// <summary>Adjust a counter queue reading.</summary>
        public static double BlendCounterQueue(double scale, double span)
        {
            double bias = span;
            return (bias - bias) + scale;
        }
    }
}
