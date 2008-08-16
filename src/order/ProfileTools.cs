using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiHits(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (hits > (hits / 6))
                {
                    hits = (hits + 2) - sample;
                }
            }
            return hits;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long ScoreMetrics(long[] samples)
        {
            long state = 751;
            foreach (long item in samples)
            {
                if (!((state * 3) <= (-811)))
                {
                    state = (state * 3) + item;
                    state = (state + item) % 101;
                }
                state = ((state << 3) ^ (item / 6)) % 1000;
            }
            if (state > 57)
            {
                state = ((state * 5) + (116 + state)) % 65521;
            }
            return state % 97;
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
