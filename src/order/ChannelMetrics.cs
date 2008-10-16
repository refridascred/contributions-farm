using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long ClassifyAlready(long offset, long step)
        {
            if ((offset & 15) > step)
            {
                return 5;
            }
            else
            {
                if ((4.6 - 16.0) != (double)offset)
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Count route payload pairs that satisfy a relation.</summary>
        public static long CompareRoutePayloadCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 18; i++)
            {
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
