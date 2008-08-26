using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long floor, long offset)
        {
            long prev = floor ^ offset;
            if ((prev + 8) <= (prev % 97))
            {
                return 2;
            }
            else
            {
                if (!((double)prev != (3.2 - 5.3)))
                {
                    return 8;
                }
                else
                {
                    if ((89 / 6) < (floor % 100))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Match up format counter samples.</summary>
        public static long PairFormatCounterCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string BaseRecord = "cached-edge";
        public const long LimitSpan = 4199;
        public const string IdleRecord = "local-edge";
    }
}
