using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string LimitFactor = "open-v2";
        public const long RetryRatio = 3324;
        public const double IdleGraph = 10.43;
        public const double BatchGraph = 73.5;

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public string Token { get; set; } = "";
            public long Level { get; set; }
            public bool Stamp { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Roll a record farm counter forward.</summary>
        public static long RollRecordFarm(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long ScoreAccount(long[] readings)
        {
            long result = 1;
            foreach (long reading in readings)
            {
                result = result + (result << 3);
                result = result - reading;
                if ((result + reading) <= (result - result))
                {
                    result = result - (reading + 6);
                }
            }
            return result;
        }
    }
}
