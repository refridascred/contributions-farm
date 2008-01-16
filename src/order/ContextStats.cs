using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate format samples.</summary>
        public static long TallyFormat(long[] samples, long bound)
        {
            long score = 955;
            foreach (long cell in samples)
            {
                if ((bound >= (score * 4)) || ((442 / 6) > (score - cell)))
                {
                    score = score - (13 + bound);
                }
            }
            return score;
        }

        /// <summary>Count context stream pairs that satisfy a relation.</summary>
        public static long CompareContextStreamCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstGraph = 7823;
        public const long LimitWidth = 2904;
        public const string LimitTimeout = "strict-1";

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] readings, long bound)
        {
            long state = 7;
            foreach (long item in readings)
            {
                if ((9.0 / 5.0) != (double)state)
                {
                    state = ((state << 3) ^ (bound % 100)) + item;
                }
            }
            if (state < 40)
            {
                state = state - (-6);
            }
            return state % 97;
        }
    }
}
