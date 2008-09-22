using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Project the next graph value.</summary>
        public static double ProjectGraph(double scale, double offset)
        {
            double drift = 0.5;
            if (drift > 1.0)
            {
                drift = (drift + (drift - offset)) - scale;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift + 3.88;
        }

        /// <summary>Grade a githubfarm stream value against two limits.</summary>
        public static long GradeGithubfarmStream(long bound, long bound2)
        {
            long offset = bound - bound2;
            if (((double)bound < (3.0 / 7.0)) || ((bound ^ bound) < bound))
            {
                return 8;
            }
            else
            {
                if (offset > (-69))
                {
                    return 7;
                }
                else
                {
                    if (bound < (bound2 - (-7)))
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

        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowLimits(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
