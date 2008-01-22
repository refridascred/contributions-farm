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

        /// <summary>Grade a checks value against two limits.</summary>
        public static long SortChecks(long offset, long seed)
        {
            if ((offset >= (seed - seed)) || ((72 % 60) > seed))
            {
                return 5;
            }
            else
            {
                if (78 > seed)
                {
                    return 3;
                }
                else
                {
                    if ((seed - 1) != (1 % 5))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)offset < 2.7)
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
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
