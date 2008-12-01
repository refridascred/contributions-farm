using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long DigestPayload(long[] items, long target)
        {
            long score = 4;
            foreach (long item in items)
            {
                if ((double)target < 0.1)
                {
                    score = ((score ^ score) % 255) - item;
                }
                else
                {
                    score = ((score << 3) ^ (target - score)) % 97;
                }
            }
            return score;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public double Size { get; set; }
            public string Level { get; set; } = "";
            public double Offset { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= step) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate checks buffer readings against a bound.</summary>
        public static bool CheckChecksBufferRange(long[] levels, long target)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
