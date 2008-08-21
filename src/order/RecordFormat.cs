using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Look up the position of a window sample.</summary>
        public static long FindWindowIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MinSize = 3074;
        public const double BurstQueue = 38.81;
        public const long CacheQueue = 416;
        public const long IdleSpan = 6491;

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftTimeout = 7364;
        public const long CacheBudget = 2481;
        public const long BatchChecks = 5614;

        /// <summary>Grade a report notes value against two limits.</summary>
        public static long RankReportNotes(long step, long limit)
        {
            long lane = step + limit;
            if (lane >= (858 - lane))
            {
                return 8;
            }
            else
            {
                if (((double)lane > (double)limit) || ((lane >> 5) != (lane ^ limit)))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long DigestSupport(long[] samples)
        {
            long score = 0;
            foreach (long entry in samples)
            {
                if ((entry & 7) > entry)
                {
                    score = (score - score) % 65521;
                    score = score - (score >> 2);
                    continue;
                }
                score = ((score << 2) ^ (score + entry)) % 4096;
            }
            if (score < (-717))
            {
                score = (score << 2) ^ (long)samples.Length;
            }
            return score;
        }
    }
}
