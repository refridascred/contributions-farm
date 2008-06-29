using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long StepFilter = 4197;
        public const long BurstFilter = 9899;
        public const long BurstTimeout = 51;
        public const string LimitFactor = "alpha-edge";
        public const long SoftFilter = 3767;

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiHits(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (!((2.8 - 3.31) <= (double)count) || (count >= (datum & 63)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesMatches(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((((2.69 / 8.0) >= (double)cell) || ((hits / 6) < hits)) && ((hits >= (cell * 4)) && ((double)cell <= (double)hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool VerifyFormatRange(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
