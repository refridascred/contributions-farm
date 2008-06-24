using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long WindowAlready = 7935;
        public const long RetrySpan = 2701;
        public const string BatchSpan = "cached";
        public const string MaxAlready = "standard-1";

        /// <summary>Derive the next already value from a seed.</summary>
        public static long RollAlready(long seed)
        {
            long state = seed;
            for (int i = 0; i < 16; i++)
            {
                state = state - (seed % 60);
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long StepCommits(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 11; i++)
            {
                mark = (mark * 2) + ((long)i * 5);
                mark = (mark + (mark + mark)) % 101;
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MinToken = 2200;
        public const long MinSize = 4527;
        public const string DefaultWidth = "legacy-v2";

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long SeriesChecks(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
