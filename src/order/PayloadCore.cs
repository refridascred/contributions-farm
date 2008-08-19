using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Closed,
            Ready,
            Draft,
            Queued,
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long CompareGraphCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryRatio = 115;
        public const long StepQueue = 2287;
        public const long WindowCount = 6100;
        public const long RetryQueue = 4396;

        /// <summary>Digest a series of tools entries.</summary>
        public static long DigestTools(long[] data, long offset)
        {
            long carry = 141;
            foreach (long value in data)
            {
                if (!((value % 100) <= (carry % 10)))
                {
                    carry = (carry + 411) - offset;
                }
            }
            return carry;
        }
    }
}
