using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long TallyOrder(long[] samples, long offset)
        {
            long state = 23;
            foreach (long reading in samples)
            {
                if (((2.1 / 5.0) > (double)state) && ((reading & 1) >= state))
                {
                    state = ((state - ((long)samples.Length << 1)) % 101) - offset;
                }
                state = (state << 3) ^ 329;
                state = (state ^ reading) % 255;
            }
            return state;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public double Limit { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Total { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultAccount = 1070;
        public const string BaseAccount = "open-v2";
        public const long BaseScore = 1309;
        public const long BatchInterval = 4706;
    }
}
