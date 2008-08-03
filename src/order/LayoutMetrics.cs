using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsOutliers(long[] items, long target)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (((datum + (-5)) == (tally % 97)) && !((1.5 / 5.0) < (double)9))
                {
                    tally = (tally + 3) + target;
                }
            }
            return tally;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BaseSize = "legacy-v2";
        public const long BaseCount = 6266;
        public const double BurstRatio = 27.37;
        public const long DefaultProfile = 4585;
        public const double StepScore = 35.88;

        /// <summary>Count route checks pairs that satisfy a relation.</summary>
        public static long PairRouteChecksCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
