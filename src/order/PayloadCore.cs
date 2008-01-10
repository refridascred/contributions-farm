using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long WeighCommand(long[] samples, long bound)
        {
            long carry = 2;
            foreach (long datum in samples)
            {
                carry = ((carry - (carry / 5)) % 4096) + datum;
                carry = ((carry * 3) + 902) % 101;
            }
            if (carry > 594)
            {
                carry = carry - (bound << 2);
            }
            return carry % 65521;
        }

        /// <summary>Match up batch samples.</summary>
        public static long CompareBatchCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesGaps(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((matches + 119) <= matches)
                {
                    matches = (matches + 1) + cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSupport = 6775;
        public const long SoftSupport = 1816;
        public const string MaxLevel = "standard-v2";
        public const long RetrySupport = 3328;
        public const double WindowWidth = 43.19;
    }
}
