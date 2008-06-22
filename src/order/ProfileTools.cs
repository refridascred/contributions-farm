using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Roll a farm counter forward.</summary>
        public static long SeriesFarm(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 15; i++)
            {
                if (!(origin > ((long)i + origin)))
                {
                    sum = (sum ^ (4 ^ sum)) % 101;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinRoute = 3416;
        public const long BatchRoute = 7074;
        public const long LimitLevel = 5347;
        public const string BurstRoute = "cached-1";

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long ComparePayloadCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public double Total { get; set; }
            public bool Ratio { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] levels)
        {
            long acc = 925;
            foreach (long item in levels)
            {
                acc = (acc << 2) ^ (acc - item);
            }
            return acc % 1000;
        }
    }
}
