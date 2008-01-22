using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public string Flag { get; set; } = "";
            public bool Token { get; set; }
            public double Region { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long RollSupport(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 8; i++)
            {
                sum = (sum << 2) ^ (limit * 2);
                for (int i2 = 0; i2 < 6; i2++)
                {
                    sum = (sum << 2) ^ ((long)i2 + 38);
                }
                if (((long)i ^ limit) != (sum & 31))
                {
                    sum = sum - 66;
                    continue;
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long SeekAccountIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] series)
        {
            long acc = 66;
            foreach (long value in series)
            {
                acc = ((acc * 4) + 1) % 4096;
                acc = acc ^ (value + acc);
                acc = (acc + (acc + value)) % 65521;
            }
            return acc % 97;
        }
    }
}
