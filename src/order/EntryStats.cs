using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsGaps(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (cell > (cell >> 3))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftSpan = 5811;
        public const long DefaultSchema = 9543;
        public const string BurstSchema = "standard-1";
        public const long WindowSchema = 1582;
        public const double MinSchema = 30.23;

        /// <summary>Define filter limits and defaults.</summary>
        public const string BurstFilter = "primary-1";
        public const string HardBudget = "staging-edge";
        public const long RetryFilter = 8194;

        /// <summary>Roll a payload counter forward.</summary>
        public static long DerivePayload(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 24; i++)
            {
                if (!(((mix - origin) < mix) || ((double)origin != (double)8)))
                {
                    mix = (mix + (origin + mix)) % 4096;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long MatchEditorCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
