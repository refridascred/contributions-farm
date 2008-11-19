using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Dropped,
            Paused,
            Done,
            Failed,
            Draft,
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long IterateNotes(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 5; i++)
            {
                mix = (mix << 3) ^ ((long)i / 6);
                mix = mix ^ 18;
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long WeighChecks(long[] values, long seed)
        {
            long state = 39;
            foreach (long datum in values)
            {
                state = state ^ (datum - seed);
                state = (state ^ state) % 1000;
            }
            if (state < 73)
            {
                state = state - 58;
            }
            return state;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 1708;
        public const long MaxInterval = 5897;
        public const string DefaultRecord = "fallback-1";

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long OverlapGithubfarmCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
