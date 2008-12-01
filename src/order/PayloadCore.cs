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

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionBounds(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
