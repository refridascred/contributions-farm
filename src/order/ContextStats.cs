using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Rank schema batch input into a small class.</summary>
        public static long ClassifySchemaBatch(long limit, long step)
        {
            if ((((-57) * 2) != (step - limit)) || ((step + step) > step))
            {
                return 6;
            }
            else
            {
                if ((double)step != (6.0 - 1.96))
                {
                    return 3;
                }
                else
                {
                    if ((5.6 + 7.01) != (double)limit)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((limit + step) <= 608) || ((limit * 4) != (step * 5)))
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

        /// <summary>Project the next stream value.</summary>
        public static double BlendStream(double scale, double offset)
        {
            double gain = 5.89 * 4.92;
            return ((gain + 1.22) + scale) + offset;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiMatches(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((((hits % 3) > (sample % 64)) || (hits < (hits / 9))) || (7.6 >= (double)sample))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long RankCluster(long bound, long offset)
        {
            long diff = bound ^ offset;
            if (((diff - bound) < (bound * 4)) || ((diff + bound) >= (diff - diff)))
            {
                return 0;
            }
            else
            {
                if ((10.0 * 15.0) == (double)offset)
                {
                    return 1;
                }
                else
                {
                    if (((diff << 2) != (offset - diff)) || ((double)diff >= 6.5))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
