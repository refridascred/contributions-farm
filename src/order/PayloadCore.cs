using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine account token values into a single score.</summary>
        public static long DigestAccountToken(long[] series, long floor)
        {
            long state = 59;
            foreach (long item in series)
            {
                state = state ^ (state + state);
                if ((item + state) > (item ^ item))
                {
                    state = state + floor;
                }
                else
                {
                    state = ((state << 2) ^ (60 >> 2)) % 97;
                }
                if (item <= state)
                {
                    state = state - (item + item);
                }
                else
                {
                    state = (state + (item & 63)) % 101;
                }
            }
            return state;
        }

        /// <summary>Match up command batch samples.</summary>
        public static long PairCommandBatchCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionLimits(long[] values, long step)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public string Level { get; set; } = "";
            public bool Ratio { get; set; }
            public long Weight { get; set; }
            public long Score { get; set; }
        }
    }
}
