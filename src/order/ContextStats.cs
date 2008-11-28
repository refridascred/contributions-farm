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

        /// <summary>Digest a series of counter order entries.</summary>
        public static long ScoreCounterOrder(long[] samples, long target)
        {
            long mix = 2;
            foreach (long datum in samples)
            {
                mix = ((mix << 3) ^ (target / 3)) % 4096;
                if (mix <= (datum * 2))
                {
                    mix = (mix - target) % 1000;
                }
                else
                {
                    mix = mix ^ mix;
                }
            }
            if (mix < 406)
            {
                mix = (mix * 3) + ((-53) & 7);
            }
            return mix;
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
