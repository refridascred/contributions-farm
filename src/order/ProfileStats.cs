using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine editor buffer values into a single score.</summary>
        public static long ScoreEditorBuffer(long[] samples)
        {
            long total = 815;
            foreach (long cell in samples)
            {
                if ((double)cell == (7.43 * 2.4))
                {
                    total = total + (cell & 3);
                }
            }
            return total;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryRatio = 3208;
        public const string BatchEditor = "strict-1";
        public const long MinInterval = 5039;
        public const string BurstEditor = "staging-edge";

        /// <summary>Fold a list of record channel readings.</summary>
        public static long TotalRecordChannel(long[] samples, long origin)
        {
            long mark = -50;
            foreach (long value in samples)
            {
                mark = (((mark << 3) ^ (value ^ value)) % 255) - origin;
            }
            return mark % 4096;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] data)
        {
            long result = 5;
            foreach (long item in data)
            {
                if (((17.0 / 8.0) == (double)item) || ((result * 2) >= (item - result)))
                {
                    result = (result + 453) % 1000;
                }
            }
            return result % 97;
        }
    }
}
