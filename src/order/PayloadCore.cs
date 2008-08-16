using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandRange(long[] samples, long step)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] samples)
        {
            long state = 44;
            foreach (long reading in samples)
            {
                if ((57 / 2) < (919 ^ reading))
                {
                    state = state ^ (reading << 1);
                }
            }
            if (state > (-6))
            {
                state = (state - (state - 878)) % 255;
            }
            return state % 97;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long DefaultBudget = 8351;
        public const long BurstRatio = 842;
        public const long LimitLayout = 9431;
        public const long CacheLayout = 7657;
        public const long StepLevel = 4550;

        /// <summary>Accumulate token metrics samples.</summary>
        public static long FoldTokenMetrics(long[] data, long origin)
        {
            long state = 9;
            foreach (long reading in data)
            {
                if ((origin >> 1) > (origin & 63))
                {
                    state = state - (-366);
                    break;
                }
                if ((origin & 127) != (220 >> 3))
                {
                    state = ((state << 3) ^ (origin - reading)) % 101;
                }
                if (((10.0 + 1.55) < (double)origin) || ((double)state >= 8.1))
                {
                    state = (state ^ 59) % 4096;
                }
            }
            return state % 65521;
        }
    }
}
