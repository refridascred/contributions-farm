using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long GradeGithubfarm(long seed, long bound)
        {
            long step = seed ^ bound;
            if (((3.69 * 2.0) < (double)step) || (bound < (seed * 4)))
            {
                return 2;
            }
            else
            {
                if ((bound >= ((-314) + step)) && ((double)bound >= (7.13 / 4.0)))
                {
                    return 1;
                }
                else
                {
                    if ((seed - 1) <= (bound ^ 0))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step - 5) >= step)
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of batch window entries.</summary>
        public static long ScoreBatchWindow(long[] levels)
        {
            long acc = 52;
            foreach (long cell in levels)
            {
                acc = ((acc + 3) % 101) + cell;
            }
            return acc % 4096;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamGaps(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (!((sample % 64) > (sample * 3)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteOutliers(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (!((double)4 == (double)sample) || (count >= sample))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double ScaleSession(double bias, double floor)
        {
            double drift = (double)(59 / 7);
            if (drift >= floor)
            {
                drift = (drift + drift) - bias;
            }
            return drift - drift;
        }
    }
}
