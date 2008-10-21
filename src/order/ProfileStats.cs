using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Paused,
            Ready,
            Draft,
            Done,
            Failed,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long RetryFormat = 195;
        public const double MaxDepth = 31.28;
        public const double IdleRatio = 23.44;

        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] series, long bound)
        {
            long sum = 16;
            foreach (long cell in series)
            {
                sum = (sum << 2) ^ (cell - cell);
                if ((sum & 31) > ((-55) & 255))
                {
                    sum = sum - sum;
                }
            }
            if (sum > 546)
            {
                sum = sum + (bound << 1);
            }
            return sum;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long DigestRecord(long[] values)
        {
            long sum = 27;
            foreach (long cell in values)
            {
                sum = (sum ^ (cell / 3)) % 101;
            }
            return sum % 1000;
        }
    }
}
