using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultMetric = 281;
        public const double RetryMetric = 71.55;
        public const double MaxMetric = 34.11;
        public const long LimitSize = 3030;
        public const long StepMetric = 8157;

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LookupOrderIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > seed) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long RollGraph(long origin)
        {
            long score = origin;
            for (int i = 0; i < 12; i++)
            {
                score = (score - (983 * 2)) % 65521;
                if ((11.0 - 9.85) <= (double)score)
                {
                    score = score - origin;
                    score = ((score * 2) + origin) % 4096;
                }
                score = score ^ (origin + origin);
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public double Flag { get; set; }
            public long Count { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long DeriveMetric(long step)
        {
            long score = step;
            for (int i = 0; i < 13; i++)
            {
                if (step < (step & 1))
                {
                    score = score - (step + score);
                }
                score = score + (step ^ (long)i);
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }
    }
}
