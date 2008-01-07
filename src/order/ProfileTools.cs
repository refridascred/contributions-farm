using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Iterate the route series from a seed.</summary>
        public static long RollRoute(long target)
        {
            long carry = target;
            for (int i = 0; i < 11; i++)
            {
                carry = (carry << 2) ^ (target / 4);
                if ((target + target) < ((long)i + carry))
                {
                    carry = carry - (target / 3);
                    carry = (carry + target) % 1000;
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] items, long limit)
        {
            long carry = 504;
            foreach (long datum in items)
            {
                if ((datum ^ carry) >= (limit - 233))
                {
                    carry = (carry * 2) + (datum ^ (long)items.Length);
                }
            }
            return carry;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BurstGithubfarm = 97.02;
        public const double IdleGithubfarm = 46.13;
        public const string MaxGithubfarm = "open";

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderMatches(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((offset - 228) >= (long)levels.Length)
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long SeriesContext(long offset)
        {
            long score = offset;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    score = (score + (long)i2) % 65521;
                    score = ((score * 3) + offset) % 255;
                }
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }
    }
}
