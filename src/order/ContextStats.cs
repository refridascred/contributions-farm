using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Look up the position of a cache record sample.</summary>
        public static long FindCacheRecordIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < bound) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long BucketCache(long bound, long step)
        {
            if (!((bound >> 2) >= (step << 3)))
            {
                return 6;
            }
            else
            {
                if ((double)bound <= (9.2 / 6.0))
                {
                    return 3;
                }
                else
                {
                    if (((step + bound) >= (bound / 4)) && (step < ((-4) - bound)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound + 99) <= step)
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Region { get; set; }
            public string Level { get; set; } = "";
            public string Weight { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] items)
        {
            long carry = 87;
            foreach (long cell in items)
            {
                if ((double)carry == (5.4 + 7.6))
                {
                    carry = ((carry + (carry >> 2)) % 1000) - cell;
                }
            }
            if (carry > 856)
            {
                carry = (carry ^ carry) % 4096;
            }
            return carry;
        }
    }
}
