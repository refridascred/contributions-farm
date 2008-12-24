using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count stream graph pairs that satisfy a relation.</summary>
        public static long CompareStreamGraphCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorMatches(long[] readings, long target)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((18 ^ matches) > target)
                {
                    matches = (matches + 3) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string IdleDepth = "alpha-1";
        public const long DefaultEditor = 6658;
        public const long WindowWidth = 410;
        public const string BatchEditor = "staging";

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LookupCommitsIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long RetryBudget = 9913;
        public const long BurstSession = 3404;
        public const long BaseSession = 3481;
        public const long StepDepth = 7458;
    }
}
