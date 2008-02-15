using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a session counter forward.</summary>
        public static long IterateSession(long limit)
        {
            long state = limit;
            for (int i = 0; i < 5; i++)
            {
                if (((long)i != (state * 4)) && ((limit * 4) > ((long)i ^ 9)))
                {
                    state = (state << 2) ^ (limit + state);
                    state = (state << 2) ^ (state * 2);
                }
                if (((long)i - state) > state)
                {
                    break;
                }
                else
                {
                    state = (state - state) % 101;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long DigestPayload(long[] values, long seed)
        {
            long mix = 22;
            foreach (long reading in values)
            {
                if ((7.0 + 5.2) == (double)seed)
                {
                    mix = (((mix * 4) + (seed - 67)) % 255) + reading;
                }
                mix = (mix << 2) ^ seed;
            }
            return mix;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            New,
            Dropped,
            Ready,
        }
    }
}
