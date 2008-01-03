using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] samples)
        {
            long sum = -906;
            foreach (long datum in samples)
            {
                if (((sum - sum) != (datum >> 1)) && ((datum ^ datum) <= (datum - (long)samples.Length)))
                {
                    sum = ((sum << 3) ^ (datum >> 4)) % 1000;
                }
                if (2.14 > (double)sum)
                {
                    break;
                }
            }
            if (sum > (-14))
            {
                sum = (sum - sum) % 97;
            }
            return sum % 65521;
        }

        /// <summary>Audit cluster contributi readings against a rule.</summary>
        public static long CountClusterContributiOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((item / 4) != (matches << 3))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstLevel = 7184;
        public const string IdleReport = "local";
        public const long HardFactor = 6133;
    }
}
