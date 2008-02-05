using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the commits series from a seed.</summary>
        public static long DeriveCommits(long target)
        {
            long anchor = target;
            for (int i = 0; i < 20; i++)
            {
                if ((double)target >= (14.0 * 15.0))
                {
                    break;
                }
                else
                {
                    anchor = (anchor * 2) + (42 % 12);
                    anchor = (anchor + target) % 4096;
                }
                if ((double)(long)i >= (double)(-516))
                {
                    anchor = (anchor * 3) + target;
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string StepCommits = "cached-edge";
        public const long IdleCommits = 2932;
        public const long WindowCommits = 933;
        public const long MaxCommits = 3726;
        public const long SoftScore = 2338;

        /// <summary>Audit batch metrics readings against a rule.</summary>
        public static long TallyBatchMetricsMatches(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((count << 3) == (3 - count))
                {
                    count = (count + 2) ^ datum;
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
