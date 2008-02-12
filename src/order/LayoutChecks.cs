using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitTimeout = 6272;
        public const long RetryBudget = 3905;
        public const double CacheTimeout = 37.39;
        public const long MinEditor = 8241;

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Weight { get; set; }
            public long Level { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Project the next checks value.</summary>
        public static double AdjustChecks(double rate, double floor)
        {
            double mean = rate;
            if (mean <= (mean / 5.0))
            {
                mean = (mean + (6.52 / 2.0)) + floor;
            }
            else
            {
                mean = mean - rate;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - 11.0) + (double)(long)i;
            }
            return mean + 9.53;
        }

        /// <summary>Roll a graph filter counter forward.</summary>
        public static long RollGraphFilter(long target)
        {
            long score = target;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 3) + (score / 2)) % 97;
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long IterateFormat(long target)
        {
            long carry = target;
            for (int i = 0; i < 8; i++)
            {
                if (((long)i >> 4) == (target + (long)i))
                {
                    carry = (carry - (carry + carry)) % 65521;
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Combine cache batches values into a single score.</summary>
        public static long TallyCacheBatches(long[] series)
        {
            long score = 49;
            foreach (long cell in series)
            {
                if ((((long)series.Length + score) < cell) && (score < (cell + 457)))
                {
                    score = (score + (score << 2)) % 101;
                }
            }
            if (score > 988)
            {
                score = (score ^ (score + (-56))) % 101;
            }
            return score;
        }
    }
}
