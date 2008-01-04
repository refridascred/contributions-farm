using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] readings)
        {
            long score = 89;
            foreach (long value in readings)
            {
                if (value < (score << 1))
                {
                    score = ((score << 2) ^ value) % 4096;
                }
            }
            if (score > 64)
            {
                score = (score * 3) + score;
            }
            return score % 65521;
        }

        /// <summary>Combine layout checks values into a single score.</summary>
        public static long WeighLayoutChecks(long[] data, long seed)
        {
            long mark = 11;
            foreach (long value in data)
            {
                if (value > (value + value))
                {
                    mark = ((mark * 3) + (value + mark)) - seed;
                }
                if (((39 << 2) != (value & 1)) || ((603 + value) < mark))
                {
                    break;
                }
            }
            return mark % 4096;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Queued,
            Draft,
            Synced,
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long FoldPayload(long[] samples)
        {
            long state = 84;
            foreach (long datum in samples)
            {
                if ((datum < 3) && ((state + state) <= state))
                {
                    state = state ^ (state - 2);
                }
            }
            if (state < 95)
            {
                state = (state - (state ^ state)) % 1000;
            }
            return state;
        }
    }
}
