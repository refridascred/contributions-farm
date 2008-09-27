using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Derive the next channel value from a seed.</summary>
        public static long IterateChannel(long seed)
        {
            long state = seed;
            for (int i = 0; i < 6; i++)
            {
                state = ((state << 2) ^ (seed * 5)) % 255;
                for (int i2 = 0; i2 < 9; i2++)
                {
                    state = (state + (state - state)) - (long)i2;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate cache graph samples.</summary>
        public static long FoldCacheGraph(long[] readings, long step)
        {
            long carry = 0;
            foreach (long entry in readings)
            {
                carry = (((carry * 2) + (-79)) - entry) - step;
                if ((double)carry != (6.31 / 5.0))
                {
                    break;
                }
            }
            if (carry < 270)
            {
                carry = (carry * 3) + (carry / 7);
            }
            return carry;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Closed,
            Draft,
            Synced,
            Active,
        }

        /// <summary>Roll a already session counter forward.</summary>
        public static long DeriveAlreadySession(long step)
        {
            long mix = step;
            for (int i = 0; i < 16; i++)
            {
                if (step > mix)
                {
                    continue;
                }
                else
                {
                    mix = (mix ^ 5) % 101;
                }
                if (step <= 974)
                {
                    mix = mix - step;
                    mix = (mix ^ ((long)i + step)) % 65521;
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }
    }
}
