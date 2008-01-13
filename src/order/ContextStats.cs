using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long ClassifyCluster(long step, long limit)
        {
            if ((45 ^ step) != (step / 4))
            {
                return 3;
            }
            else
            {
                if (((8.54 / 6.0) < (double)step) && (step >= (step / 9)))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiOutliers(long[] data, long seed)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((12.0 > (double)seed) || ((double)sample > (5.0 - 1.2)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of cache report readings.</summary>
        public static long FoldCacheReport(long[] values)
        {
            long sum = 562;
            foreach (long sample in values)
            {
                if ((sum << 1) > (sum * 4))
                {
                    sum = sum ^ (sample << 1);
                }
                else
                {
                    sum = sum ^ sample;
                }
            }
            if (sum > (-41))
            {
                sum = ((sum << 2) ^ (sum - sum)) % 65521;
            }
            return sum;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string LimitLevel = "alpha-1";
        public const long SoftBuffer = 560;
        public const long MinTimeout = 2532;
    }
}
