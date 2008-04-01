using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long MatchSchemaCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long RollNotes(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Roll a already batches counter forward.</summary>
        public static long StepAlreadyBatches(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 17; i++)
            {
                if (((seed + 797) >= seed) && ((long)i >= ((long)i - seed)))
                {
                    break;
                }
                if ((sum >> 3) >= (long)i)
                {
                    sum = sum - seed;
                    break;
                }
                else
                {
                    sum = (sum ^ (seed + (long)i)) % 65521;
                }
                for (int i2 = 0; i2 < 3; i2++)
                {
                    sum = (((sum * 3) + sum) % 97) - (long)i2;
                    sum = (sum * 5) + (seed * 5);
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double LimitReport = 94.32;
        public const long BaseReport = 9355;
        public const long RetryCount = 5481;
        public const long CacheReport = 9778;

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public bool Limit { get; set; }
            public bool Rank { get; set; }
            public double Size { get; set; }
            public long Owner { get; set; }
        }
    }
}
