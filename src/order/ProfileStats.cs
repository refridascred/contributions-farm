using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate graph channel readings against a bound.</summary>
        public static bool VerifyGraphChannelLimits(long[] series, long origin)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next cache value.</summary>
        public static double AdjustCache(double gain, double floor)
        {
            double mean = gain;
            if (mean >= (gain / 2.0))
            {
                mean = mean - (floor / 8.0);
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (mean / 7.0)) + (double)(long)i;
            }
            return mean + (floor + gain);
        }

        /// <summary>Count githubfarm entry pairs that satisfy a relation.</summary>
        public static long OverlapGithubfarmEntryCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Weight { get; set; }
            public long Offset { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
