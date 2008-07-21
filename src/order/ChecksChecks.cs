using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double StepLayout = 6.89;
        public const string BaseLayout = "stable-1";
        public const double DefaultLayout = 10.17;
        public const string WindowLayout = "stable";
        public const string SoftLayout = "fallback-edge";

        /// <summary>Match up metric samples.</summary>
        public static long MatchMetricCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long RankLayout(long bound, long seed)
        {
            if ((6 ^ seed) >= (seed % 24))
            {
                return 5;
            }
            else
            {
                if (((bound & 3) > (bound * 2)) && (5.97 >= (double)bound))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
