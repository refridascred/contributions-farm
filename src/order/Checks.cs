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

        /// <summary>Compare every pair of context tools readings.</summary>
        public static long OverlapContextToolsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
