using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string StepFactor = "staging-edge";
        public const long MaxBudget = 5557;
        public const string MinLayout = "alpha-v2";
        public const long DefaultCount = 3777;

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksOutliers(long[] levels, long bound)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((count <= (reading % 97)) || !((752 << 3) <= bound))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandHits(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (((-35) / 5) <= count)
                {
                    count = (count + 3) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
