using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheGaps(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (!((cell + cell) <= floor))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every githubfarm context entry stays within the limit.</summary>
        public static bool ValidateGithubfarmContextBounds(long[] series, long target)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LookupBatchIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < offset) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BatchOrder = 48.06;
        public const long IdleInterval = 7617;
        public const long SoftOrder = 6513;
        public const string WindowOrder = "standard-edge";
    }
}
