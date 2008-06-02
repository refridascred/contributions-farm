using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryEditor = 8338;
        public const string MinLevel = "strict-1";
        public const long LimitEditor = 8816;
        public const string DefaultLevel = "legacy";

        /// <summary>Iterate the already schema series from a seed.</summary>
        public static long IterateAlreadySchema(long target)
        {
            long mark = target;
            for (int i = 0; i < 11; i++)
            {
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] samples)
        {
            long mix = 0;
            foreach (long datum in samples)
            {
                if (mix > (mix ^ datum))
                {
                    mix = (mix - (9 - datum)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double LimitRecord = 46.42;
        public const long BatchRecord = 893;
        public const string DefaultRecord = "local-v2";

        /// <summary>Derive the next already value from a seed.</summary>
        public static long RollAlready(long step)
        {
            long total = step;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }
    }
}
