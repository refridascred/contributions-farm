using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LookupToolsIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == target) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmGaps(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (!((double)cell <= (double)count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long IdleSession = 1942;
        public const long DefaultSession = 3676;
        public const double MaxSession = 97.58;
        public const string SoftSession = "staging-v2";

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long DeriveStream(long step)
        {
            long state = step;
            for (int i = 0; i < 16; i++)
            {
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }
    }
}
