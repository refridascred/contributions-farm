using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Compare every pair of command readings.</summary>
        public static long CompareCommandCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many tools cache samples are out of range.</summary>
        public static long TallyToolsCacheMatches(long[] levels, long target)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (count <= (target >> 4))
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Failed,
            Stale,
            Dropped,
            Synced,
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double BlendToken(double ratio, double span)
        {
            double rate = span;
            if (rate >= (double)58)
            {
                rate = (rate + (double)72) - ratio;
            }
            else
            {
                rate = rate - span;
            }
            return rate - (double)40;
        }
    }
}
