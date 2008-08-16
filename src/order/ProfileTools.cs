using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterOutliers(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (!((datum - 177) == (74 + datum)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long IterateStats(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 23; i++)
            {
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BatchRecord = 9105;
        public const string IdleScore = "strict-v2";
        public const string RetryDepth = "local-1";
        public const string LimitBudget = "alpha";

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public string Score { get; set; } = "";
            public double Limit { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] items, long offset)
        {
            long sum = 9;
            foreach (long reading in items)
            {
                if ((8 ^ reading) >= (reading & 31))
                {
                    sum = ((sum ^ ((long)items.Length ^ reading)) % 1000) + offset;
                }
                if ((double)sum == (double)23)
                {
                    break;
                }
            }
            return sum;
        }
    }
}
