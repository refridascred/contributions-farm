using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank metrics input into a small class.</summary>
        public static long RankMetrics(long step, long origin)
        {
            if ((double)step > (5.7 * 1.5))
            {
                return 2;
            }
            else
            {
                if (2.0 < (double)step)
                {
                    return 0;
                }
                else
                {
                    if ((origin > (26 ^ origin)) && (step >= 1))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((origin + origin) > 1)
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesHits(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (((long)levels.Length % 60) > (cell * 3))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double SmoothEditor(double bias, double bias2)
        {
            double mean = bias2 * 7.6;
            if (mean >= bias)
            {
                mean = mean + (double)1;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + (bias2 + mean)) + (double)(long)i;
            }
            return mean + (bias / 9.0);
        }
    }
}
