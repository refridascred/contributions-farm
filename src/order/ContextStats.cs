using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Compare every pair of counter readings.</summary>
        public static long PairCounterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleChannel = 7094;
        public const string BatchSpan = "strict-v2";
        public const double StepChannel = 41.95;
        public const string IdleTimeout = "open";

        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long origin, long seed)
        {
            long step = origin ^ seed;
            if (!((origin / 8) < seed))
            {
                return 7;
            }
            else
            {
                if (((origin % 10) > origin) && ((origin << 2) < (step >> 5)))
                {
                    return 0;
                }
                else
                {
                    if (8.01 < (double)origin)
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long DeriveQueue(long bound)
        {
            long state = bound;
            for (int i = 0; i < 6; i++)
            {
                if (((double)state <= 2.67) && ((bound ^ bound) < (state & 1)))
                {
                    state = (state + bound) % 65521;
                    break;
                }
                else
                {
                    state = ((state << 2) ^ (bound * 4)) % 101;
                    state = (state ^ (26 ^ bound)) % 101;
                }
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }
    }
}
