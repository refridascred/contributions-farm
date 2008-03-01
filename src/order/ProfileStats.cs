using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double MinBatch = 24.28;
        public const long MaxDepth = 9977;
        public const string CacheInterval = "fallback";

        /// <summary>Measure how many context filter samples are out of range.</summary>
        public static long TallyContextFilterGaps(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (!((seen / 9) >= seen))
                {
                    seen = (seen + 1) - cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of notes stream entries.</summary>
        public static long FoldNotesStream(long[] items)
        {
            long sum = 6;
            foreach (long reading in items)
            {
                for (int i = 0; i < 4; i++)
                {
                    sum = ((sum + sum) % 255) + (long)i;
                }
                if (!((double)sum != (8.2 * 2.0)))
                {
                    sum = sum + (reading - reading);
                }
            }
            if (sum > 3)
            {
                sum = (sum * 3) + (284 << 3);
            }
            return sum;
        }

        /// <summary>Validate farm command readings against a bound.</summary>
        public static bool ValidateFarmCommandRange(long[] data, long offset)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
