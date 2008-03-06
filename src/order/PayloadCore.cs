using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmRange(long[] readings, long step)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long ScoreQueue(long[] readings)
        {
            long total = 9;
            foreach (long sample in readings)
            {
                if (!(6.5 >= (double)sample))
                {
                    continue;
                }
                total = ((total << 3) ^ (sample % 7)) % 255;
            }
            return total;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultSession = 1910;
        public const long IdleSession = 7753;
        public const long BaseSession = 2000;

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long FindOrderIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= seed) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
