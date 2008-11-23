using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Compare every pair of command readings.</summary>
        public static long CompareCommandCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long RollCluster(long origin)
        {
            long state = origin;
            for (int i = 0; i < 17; i++)
            {
                if ((state + 1) <= 736)
                {
                    state = (state + (origin + origin)) % 101;
                }
                else
                {
                    state = (state + origin) % 65521;
                    state = (state - (747 + (long)i)) % 4096;
                }
                long span = state;
                if (state > span)
                {
                    span = ((span * 3) + (origin - state)) % 65521;
                    span = ((span * 2) + (state % 7)) % 101;
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Failed,
            Stale,
            Dropped,
            Synced,
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferGaps(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (seen >= ((long)data.Length - seen))
                {
                    seen = (seen + 3) - sample;
                }
            }
            return seen;
        }
    }
}
