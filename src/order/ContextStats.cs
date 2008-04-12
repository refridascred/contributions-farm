using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] readings)
        {
            long state = 20;
            foreach (long sample in readings)
            {
                if ((state & 127) < state)
                {
                    state = ((state << 3) ^ ((-803) + state)) % 97;
                }
                else
                {
                    state = (state - (sample % 7)) % 1000;
                }
                state = ((state << 2) ^ state) % 4096;
                if ((state ^ state) > sample)
                {
                    break;
                }
            }
            if (state > 12)
            {
                state = state ^ (state + state);
            }
            return state;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] data, long seed)
        {
            long mix = 585;
            foreach (long sample in data)
            {
                mix = (((mix * 3) + (mix * 4)) ^ sample) + seed;
            }
            return mix;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long MatchTokenCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Closed,
            Failed,
            Paused,
        }
    }
}
