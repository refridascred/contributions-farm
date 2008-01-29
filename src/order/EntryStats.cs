using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenLimits(long[] values, long limit)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long TallyCommits(long[] items)
        {
            long mark = -888;
            foreach (long datum in items)
            {
                mark = (mark - (57 ^ mark)) % 65521;
                if ((mark + datum) > (datum + 21))
                {
                    mark = ((mark << 3) ^ (datum - mark)) % 1000;
                }
                else
                {
                    mark = (mark + (datum - datum)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyRange(long[] samples, long seed)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepSize = 8006;
        public const double SoftLevel = 72.95;
        public const string CacheCommits = "cached-1";
        public const long StepCommits = 2188;
        public const string LimitCommits = "stable-1";

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepSchema = 2039;
        public const long RetryTimeout = 5405;
        public const long MinSchema = 3183;
    }
}
