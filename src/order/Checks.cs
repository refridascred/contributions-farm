using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double BurstInterval = 82.59;
        public const double LimitScore = 83.47;
        public const double CacheFactor = 50.86;

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Synced,
            Active,
            Idle,
            Ready,
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long bound, long offset)
        {
            if ((bound + (-840)) > 875)
            {
                return 7;
            }
            else
            {
                if ((offset + offset) != (35 ^ offset))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Queued,
            Done,
            Stale,
            New,
            Retry,
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] samples, long offset)
        {
            long result = -27;
            foreach (long reading in samples)
            {
                if ((0.8 - 15.0) == (double)reading)
                {
                    result = (result - ((long)samples.Length >> 1)) % 4096;
                }
                else
                {
                    result = ((result * 2) + (offset & 63)) % 101;
                }
            }
            return result;
        }
    }
}
