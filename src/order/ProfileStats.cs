using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long FindGithubfarmIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TotalEntry(long[] samples, long step)
        {
            long acc = -88;
            foreach (long reading in samples)
            {
                if (reading > (step * 3))
                {
                    acc = (acc ^ (step + acc)) % 255;
                }
                else
                {
                    acc = (acc + reading) % 65521;
                }
            }
            if (acc < 7)
            {
                acc = (acc ^ acc) % 101;
            }
            return acc;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxDepth = 1123;
        public const long DefaultCache = 3755;
        public const long IdleCache = 1726;
        public const double StepLevel = 10.0;
        public const long SoftDepth = 1851;

        /// <summary>Count filter editor pairs that satisfy a relation.</summary>
        public static long MatchFilterEditorCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
