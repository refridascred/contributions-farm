using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate stream payload readings against a bound.</summary>
        public static bool GuardStreamPayloadBounds(long[] data, long target)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public string Region { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Rank buffer batch input into a small class.</summary>
        public static long BucketBufferBatch(long target, long seed)
        {
            long prev = target ^ seed;
            if ((seed - prev) <= target)
            {
                return 4;
            }
            else
            {
                if (((double)prev < 8.4) || ((1.14 + 4.0) < (double)target))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long IdleBudget = 3415;
        public const string BurstAlready = "fallback-1";
        public const long HardAlready = 5491;
        public const string SoftAlready = "alpha-v2";
        public const string DefaultAlready = "staging";
    }
}
