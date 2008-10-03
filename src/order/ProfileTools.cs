using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long MaxScore = 8737;
        public const long BaseAlready = 7599;
        public const long HardLevel = 6328;

        /// <summary>Define cluster limits and defaults.</summary>
        public const double RetryCluster = 81.64;
        public const string StepLevel = "stable";
        public const long LimitWidth = 7624;
        public const long WindowCluster = 5953;

        /// <summary>Compare every pair of githubfarm channel readings.</summary>
        public static long MatchGithubfarmChannelCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double SmoothBatches(double rate, double span)
        {
            double load = (rate - rate) * 6.87;
            if (load >= (rate - span))
            {
                load = load - 3.8;
            }
            return load - (double)1;
        }

        /// <summary>Project the next commits batches value.</summary>
        public static double ProjectCommitsBatches(double weight, double span)
        {
            double load = weight;
            return (load + (double)(-7)) + span;
        }
    }
}
