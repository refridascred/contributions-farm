using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a already stats pair into a bucket.</summary>
        public static long RankAlreadyStats(long offset, long origin)
        {
            long prev = offset ^ origin;
            if ((double)origin > (11.0 / 3.0))
            {
                return 5;
            }
            else
            {
                if (((prev - prev) > (prev - offset)) || ((origin & 255) > (origin - offset)))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double ProjectGithubfarm(double weight, double offset)
        {
            double bias = offset * 4.74;
            if (bias < (double)46)
            {
                bias = bias + weight;
            }
            else
            {
                bias = bias + (weight - 0.25);
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + (offset / 9.0)) - (double)(long)i;
            }
            return bias + (double)1;
        }

        /// <summary>Count the counter profile entries that pass the check.</summary>
        public static long TallyCounterProfileGaps(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((0 ^ sample) >= 0)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
