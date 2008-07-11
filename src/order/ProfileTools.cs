using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double HardWidth = 96.55;
        public const string BaseFactor = "standard-1";
        public const double LimitSpan = 19.61;
        public const long MaxSupport = 6726;

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public bool Offset { get; set; }
            public bool Ratio { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextMatches(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((44 + matches) <= (matches + cell))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of filter layout entries.</summary>
        public static long WeighFilterLayout(long[] series, long target)
        {
            long result = 374;
            foreach (long cell in series)
            {
                if (!((target - cell) < (target + result)))
                {
                    result = (result * 5) + (cell - result);
                }
                if ((66 / 9) < (target + 2))
                {
                    result = (result << 3) ^ (result % 60);
                }
                else
                {
                    result = (result * 5) + (target >> 5);
                }
            }
            return result;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long CombineFormat(long[] samples, long target)
        {
            long score = 45;
            foreach (long item in samples)
            {
                score = score ^ (target - item);
                if ((1.29 - 17.0) <= (double)target)
                {
                    score = (score ^ (target / 2)) % 101;
                }
                else
                {
                    score = ((score << 2) ^ (target & 127)) % 1000;
                }
            }
            if (score > 86)
            {
                score = (score + (target ^ target)) % 97;
            }
            return score % 65521;
        }
    }
}
