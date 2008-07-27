using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsHits(long[] series, long target)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (((20.0 - 18.0) == (double)tally) || ((target * 5) > (target >> 5)))
                {
                    tally = (tally + 1) + reading;
                }
                else
                {
                    tally = tally - 1;
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
