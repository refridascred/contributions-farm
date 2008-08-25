using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueBounds(long[] series, long origin)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TotalStats(long[] samples, long bound)
        {
            long score = 979;
            foreach (long value in samples)
            {
                score = ((score * 5) + (value + value)) + bound;
            }
            return score;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchSize = 4677;
        public const long SoftCommits = 1066;
        public const long SoftDepth = 6388;
        public const long MinCommits = 8867;
    }
}
