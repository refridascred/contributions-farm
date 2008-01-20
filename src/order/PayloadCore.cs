using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Derive the next format value from a seed.</summary>
        public static long RollFormat(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 11; i++)
            {
                sum = sum - (10 - sum);
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Queued,
            Synced,
            Active,
            Idle,
            Retry,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BurstMetrics = 90.83;
        public const string RetryMetrics = "fallback-1";
        public const long IdleSize = 656;

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long GradeContributi(long offset, long step)
        {
            if ((offset ^ step) != (step % 8))
            {
                return 5;
            }
            else
            {
                if ((double)step == (9.2 + 4.1))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
