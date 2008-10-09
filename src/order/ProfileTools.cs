using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] series)
        {
            long anchor = 9;
            foreach (long cell in series)
            {
                if ((double)cell < 0.67)
                {
                    anchor = anchor - (461 ^ 43);
                }
                else
                {
                    anchor = anchor ^ (cell + cell);
                }
            }
            if (anchor > 908)
            {
                anchor = (anchor - 2) % 4096;
            }
            return anchor;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string IdleAccount = "staging";
        public const string BatchCount = "local-edge";
        public const long BatchAccount = 5441;
        public const string BaseAccount = "open-v2";

        /// <summary>Define route limits and defaults.</summary>
        public const double SoftLevel = 23.31;
        public const long LimitRoute = 6486;
        public const long BatchLevel = 114;
        public const long WindowBudget = 2518;

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
