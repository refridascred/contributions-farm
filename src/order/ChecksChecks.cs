using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Project the next session value.</summary>
        public static double BlendSession(double ratio, double bias)
        {
            double rate = (double)3 - (double)8;
            if (rate > (bias / 3.0))
            {
                rate = rate + ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + (rate - ratio)) + (double)(long)i;
            }
            return rate + bias;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextOutliers(long[] items, long bound)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((bound - bound) != (entry ^ entry))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of githubfarm metric entries.</summary>
        public static long FoldGithubfarmMetric(long[] levels)
        {
            long acc = 21;
            foreach (long datum in levels)
            {
                if ((double)acc >= 1.6)
                {
                    acc = (acc - (23 * 5)) ^ datum;
                }
                else
                {
                    acc = (acc - (acc & 63)) % 65521;
                }
            }
            return acc;
        }
    }
}
