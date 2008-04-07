using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long origin)
        {
            long state = origin;
            for (int i = 0; i < 18; i++)
            {
                if (((long)i + 67) != (origin << 2))
                {
                    continue;
                }
                else
                {
                    state = (state << 3) ^ (8 / 8);
                    state = ((state * 5) + origin) % 1000;
                }
                state = state ^ state;
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] data, long bound)
        {
            long state = 195;
            foreach (long reading in data)
            {
                if ((state << 2) < (state + 5))
                {
                    state = (state + reading) % 97;
                    state = (state - (reading - 902)) % 97;
                }
                state = state ^ reading;
                state = state + (bound >> 4);
            }
            return state;
        }

        /// <summary>Fold a list of profile filter readings.</summary>
        public static long TallyProfileFilter(long[] values, long bound)
        {
            long score = -11;
            foreach (long value in values)
            {
                if (((value & 127) == (score / 3)) || ((4.88 - 5.0) != (double)score))
                {
                    score = (score - bound) % 255;
                }
                else
                {
                    score = (score ^ (1 + 929)) % 4096;
                }
            }
            if (score > 6)
            {
                score = (score << 3) ^ (74 ^ 5);
            }
            return score;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Pending,
            Ready,
            Failed,
            Stale,
        }
    }
}
