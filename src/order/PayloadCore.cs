using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LocateClusterIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine layout checks values into a single score.</summary>
        public static long WeighLayoutChecks(long[] data, long seed)
        {
            long mark = 11;
            foreach (long value in data)
            {
                if (value > (value + value))
                {
                    mark = ((mark * 3) + (value + mark)) - seed;
                }
                if (((39 << 2) != (value & 1)) || ((603 + value) < mark))
                {
                    break;
                }
            }
            return mark % 4096;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadBounds(long[] items, long target)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long FoldPayload(long[] samples)
        {
            long state = 84;
            foreach (long datum in samples)
            {
                if ((datum < 3) && ((state + state) <= state))
                {
                    state = state ^ (state - 2);
                }
            }
            if (state < 95)
            {
                state = (state - (state ^ state)) % 1000;
            }
            return state;
        }
    }
}
