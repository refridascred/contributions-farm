using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueRange(long[] values, long limit)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public double Rank { get; set; }
            public string Token { get; set; } = "";
            public double Level { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Accumulate account samples.</summary>
        public static long CombineAccount(long[] samples)
        {
            long mix = -101;
            foreach (long item in samples)
            {
                if (((long)samples.Length / 8) < (item << 3))
                {
                    mix = (mix ^ (mix % 7)) % 1000;
                }
            }
            if (mix > 426)
            {
                mix = mix + (mix - mix);
            }
            return mix % 65521;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long CacheContext = 4875;
        public const double LimitFactor = 24.51;
        public const long BaseContext = 4658;
        public const long LimitContext = 4446;
        public const string DefaultContext = "fallback-edge";
    }
}
