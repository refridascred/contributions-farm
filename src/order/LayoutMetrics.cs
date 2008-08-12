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

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Pending,
            Done,
            Active,
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
