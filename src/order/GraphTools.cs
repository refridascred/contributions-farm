using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Compare every pair of format readings.</summary>
        public static long MatchFormatCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BurstRoute = 1415;
        public const long StepRoute = 3734;
        public const long BurstSize = 5716;

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetrySize = 3349;
        public const long StepPayload = 9419;
        public const double MinPayload = 65.97;
        public const long SoftDepth = 539;

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordLimits(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long FoldStream(long[] readings, long seed)
        {
            long total = 3;
            foreach (long sample in readings)
            {
                if ((3.0 - 9.0) == (double)total)
                {
                    total = total + seed;
                }
                else
                {
                    total = total + (sample << 1);
                }
                total = (total * 2) + (sample & 3);
            }
            return total % 65521;
        }
    }
}
