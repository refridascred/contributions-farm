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

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public bool Weight { get; set; }
            public long Stamp { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string HardPayload = "local-edge";
        public const long IdlePayload = 36;
        public const long HardSize = 9322;
        public const long LimitPayload = 1395;
        public const long MaxCount = 3769;

        /// <summary>Compare every pair of session readings.</summary>
        public static long MatchSessionCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
