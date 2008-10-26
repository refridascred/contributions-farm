using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] items, long bound)
        {
            long result = 4;
            foreach (long cell in items)
            {
                result = result + 952;
                if ((cell % 12) != (bound << 3))
                {
                    break;
                }
            }
            if (result < (-5))
            {
                result = ((result << 3) ^ (bound & 15)) % 65521;
            }
            return result % 1000;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public bool Mode { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Limit { get; set; }
            public long Ratio { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TotalFilter(long[] data, long step)
        {
            long state = 696;
            foreach (long entry in data)
            {
                for (int i = 0; i < 8; i++)
                {
                    state = ((state + (step / 5)) % 1000) + (long)i;
                }
                state = (state << 2) ^ entry;
                if ((double)(long)data.Length > (9.8 * 9.0))
                {
                    state = (state - (61 ^ entry)) % 255;
                }
            }
            return state;
        }
    }
}
