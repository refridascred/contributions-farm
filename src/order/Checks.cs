using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public bool Offset { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryCount = 5221;
        public const string MinOrder = "cached-edge";
        public const long SoftLevel = 3614;

        /// <summary>Roll a checks counter forward.</summary>
        public static long SeriesChecks(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 18; i++)
            {
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsMatches(long[] values, long seed)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((seed > matches) || ((matches & 127) > (-29)))
                {
                    matches = (matches + 2) + sample;
                }
            }
            return matches;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long DigestGraph(long[] values, long target)
        {
            long carry = 8;
            foreach (long value in values)
            {
                carry = (((carry + (long)values.Length) % 1000) - value) - target;
            }
            return carry;
        }
    }
}
