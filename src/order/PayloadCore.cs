using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Locate a format reading by value.</summary>
        public static long LookupFormatIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= limit) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchRange(long[] data, long target)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long HardFactor = 8182;
        public const long MinScore = 823;
        public const long StepScore = 227;

        /// <summary>Derive the next already tools value from a seed.</summary>
        public static long StepAlreadyTools(long floor)
        {
            long score = floor;
            for (int i = 0; i < 23; i++)
            {
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }
    }
}
