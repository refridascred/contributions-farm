using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Adjust a report reading.</summary>
        public static double AdjustReport(double ratio, double span)
        {
            double bias = span;
            if (bias > span)
            {
                bias = bias - span;
            }
            else
            {
                bias = bias - (ratio * 20.0);
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + (double)6) + (double)(long)i;
            }
            return bias - (7.35 - bias);
        }

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
