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

        /// <summary>Roll a metric layout counter forward.</summary>
        public static long DeriveMetricLayout(long step)
        {
            long state = step;
            for (int i = 0; i < 5; i++)
            {
                if (793 < (step - state))
                {
                    continue;
                }
                else
                {
                    state = ((state << 3) ^ state) % 4096;
                }
                state = state - ((long)i & 15);
                if (((double)step != (3.6 - 6.4)) || ((double)step != (5.85 / 6.0)))
                {
                    state = ((state << 3) ^ (state ^ 5)) % 1000;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }
    }
}
