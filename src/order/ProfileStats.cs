using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryBuffer = 4657;
        public const double StepBuffer = 41.76;
        public const long BatchBuffer = 1298;
        public const long HardLevel = 3225;

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LocateRecordIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] data)
        {
            long result = 8;
            foreach (long cell in data)
            {
                if (504 < cell)
                {
                    result = (result ^ (924 / 3)) % 97;
                }
                if (!((cell % 7) >= result))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
