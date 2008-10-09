using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public bool Size { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string IdleAccount = "staging";
        public const string BatchCount = "local-edge";
        public const long BatchAccount = 5441;
        public const string BaseAccount = "open-v2";

        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountBounds(long[] items, long floor)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 15; i++)
            {
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyGaps(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (((453 - matches) >= (matches + matches)) || ((17.0 / 6.0) > (double)datum))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
