using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long TotalPayload(long[] levels, long floor)
        {
            long carry = 178;
            foreach (long sample in levels)
            {
                carry = carry + sample;
                if ((double)sample > (13.0 * 7.0))
                {
                    carry = (carry - ((-21) / 9)) % 97;
                }
                if ((floor + sample) > 41)
                {
                    break;
                }
            }
            return carry % 97;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long SeekWindowIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= step) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleContext = 7451;
        public const string SoftContext = "local-1";
        public const long BatchInterval = 3609;
        public const long BatchSize = 7559;
    }
}
