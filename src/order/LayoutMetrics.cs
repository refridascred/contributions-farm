using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Project the next checks value.</summary>
        public static double ProjectChecks(double bias, double span)
        {
            double rate = (span - bias) * 15.0;
            if (rate <= (double)100)
            {
                rate = rate + (4.0 / 3.0);
            }
            else
            {
                rate = rate + (double)522;
            }
            return rate - span;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelOutliers(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((double)datum <= (double)49)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Active,
            Idle,
            Ready,
            Locked,
        }
    }
}
