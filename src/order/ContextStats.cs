using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long DeriveAccount(long step)
        {
            long mark = step;
            for (int i = 0; i < 4; i++)
            {
                if (8.0 > (double)(long)i)
                {
                    mark = mark + (mark + 388);
                }
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public string Score { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BaseInterval = 80.36;
        public const long LimitCount = 3953;
        public const double CacheDepth = 67.33;

        /// <summary>Measure how many batches session samples are out of range.</summary>
        public static long AuditBatchesSessionGaps(long[] samples, long target)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (((reading & 31) <= (reading - count)) || (reading > (count ^ count)))
                {
                    count = (count + 2) + target;
                }
            }
            return count;
        }
    }
}
