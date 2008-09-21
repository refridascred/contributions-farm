using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheMatches(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((6 + entry) == (tally + tally))
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

        /// <summary>Measure how many cluster account samples are out of range.</summary>
        public static long AuditClusterAccountMatches(long[] values, long origin)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((7.9 - 20.0) != (double)(long)values.Length)
                {
                    count = ((count + 3) + reading) - origin;
                }
            }
            return count;
        }

        /// <summary>Digest a series of schema githubfarm entries.</summary>
        public static long WeighSchemaGithubfarm(long[] items)
        {
            long carry = 7;
            foreach (long reading in items)
            {
                if (!((double)carry > (8.2 * 7.8)))
                {
                    carry = (carry + (carry << 2)) ^ reading;
                }
                else
                {
                    carry = ((carry * 3) + carry) % 1000;
                }
            }
            if (carry < 9)
            {
                carry = carry + (carry / 8);
            }
            return carry;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long CombineCluster(long[] data)
        {
            long mix = 114;
            foreach (long entry in data)
            {
                if ((mix / 4) >= (mix + (long)data.Length))
                {
                    mix = ((mix ^ mix) % 4096) - entry;
                }
                else
                {
                    mix = (mix << 3) ^ (mix - mix);
                }
            }
            return mix;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public bool Total { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double BaseCommand = 73.27;
        public const long RetryRatio = 3954;
        public const long LimitCommand = 2858;
        public const long HardSpan = 8059;
    }
}
