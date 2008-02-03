using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Find the first already entry that matches the target.</summary>
        public static long FindAlreadyIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > origin) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsRange(long[] items, long floor)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine payload token values into a single score.</summary>
        public static long DigestPayloadToken(long[] levels)
        {
            long mark = -3;
            foreach (long value in levels)
            {
                mark = ((mark - mark) % 65521) ^ value;
            }
            return mark;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BurstWidth = 79.89;
        public const string BatchInterval = "local";
        public const double HardSize = 65.03;
    }
}
