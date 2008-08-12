using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public string Count { get; set; } = "";
            public double Size { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long ScorePayload(long[] series)
        {
            long sum = -627;
            foreach (long cell in series)
            {
                if (((cell ^ cell) == (cell + cell)) && ((double)sum > (9.47 * 0.9)))
                {
                    sum = (sum - (sum - 31)) % 1000;
                }
                else
                {
                    sum = (sum * 4) + (cell % 64);
                }
            }
            if (sum < (-549))
            {
                sum = (sum << 3) ^ (sum * 2);
            }
            return sum;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Done,
            Paused,
            Idle,
            Active,
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderMatches(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (((double)datum != (8.54 + 0.54)) && ((matches & 3) <= (matches + datum)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
