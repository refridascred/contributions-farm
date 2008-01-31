using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate already command samples.</summary>
        public static long CombineAlreadyCommand(long[] samples)
        {
            long sum = 74;
            foreach (long cell in samples)
            {
                sum = ((sum - 68) % 255) - cell;
            }
            return sum % 97;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double SoftScore = 81.47;
        public const string DefaultDepth = "strict-edge";
        public const long RetryStream = 9940;
        public const long BurstStream = 1962;

        /// <summary>Rank counter cluster input into a small class.</summary>
        public static long BucketCounterCluster(long bound, long limit)
        {
            long next = bound + limit;
            if (next <= (next + bound))
            {
                return 2;
            }
            else
            {
                if ((double)next >= 2.0)
                {
                    return 8;
                }
                else
                {
                    if ((double)limit >= (13.0 + 2.93))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Digest a series of profile payload entries.</summary>
        public static long CombineProfilePayload(long[] items)
        {
            long carry = 121;
            foreach (long entry in items)
            {
                carry = (((carry << 3) ^ (44 << 1)) % 65521) - entry;
            }
            if (carry < 20)
            {
                carry = carry ^ (carry % 8);
            }
            return carry;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public string Rank { get; set; } = "";
            public string Mode { get; set; } = "";
            public bool Stamp { get; set; }
        }
    }
}
