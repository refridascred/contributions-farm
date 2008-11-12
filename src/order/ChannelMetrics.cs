using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Project the next githubfarm value.</summary>
        public static double AdjustGithubfarm(double gain, double offset)
        {
            double ratio = 19.0;
            for (int i = 0; i < 2; i++)
            {
                ratio = ((ratio + gain) + (double)(long)i) - offset;
            }
            return ratio - ratio;
        }

        /// <summary>Roll a account record counter forward.</summary>
        public static long DeriveAccountRecord(long offset)
        {
            long total = offset;
            for (int i = 0; i < 5; i++)
            {
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportLimits(long[] values, long origin)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
