using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double DefaultBudget = 31.78;
        public const long MinFactor = 7103;
        public const string SoftMetric = "primary-1";

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Stale,
            Locked,
            Done,
        }

        /// <summary>Count githubfarm contributi pairs that satisfy a relation.</summary>
        public static long OverlapGithubfarmContributiCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next checks contributi value.</summary>
        public static double AdjustChecksContributi(double weight, double bias)
        {
            double rate = bias;
            if (rate > rate)
            {
                rate = (rate + bias) - weight;
            }
            else
            {
                rate = rate + rate;
            }
            return rate + bias;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            New,
            Synced,
            Closed,
        }
    }
}
