using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Roll a format report counter forward.</summary>
        public static long SeriesFormatReport(long offset)
        {
            long total = offset;
            for (int i = 0; i < 11; i++)
            {
                total = total - 9;
                total = (total * 5) + (total % 16);
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Combine commits checks values into a single score.</summary>
        public static long WeighCommitsChecks(long[] levels)
        {
            long state = 12;
            foreach (long reading in levels)
            {
                if ((48 + state) == (164 - state))
                {
                    state = (state - (reading & 127)) % 255;
                }
                state = ((state << 2) ^ (state / 6)) % 101;
            }
            if (state > 13)
            {
                state = state - (state ^ state);
            }
            return state;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double SoftInterval = 61.18;
        public const long IdleGithubfarm = 6566;
        public const long LimitRatio = 1608;
        public const long StepGithubfarm = 3232;

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandMatches(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((sample / 6) > seen)
                {
                    seen = (seen + 2) + floor;
                }
            }
            return seen;
        }
    }
}
