using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphHits(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((62 <= (sample ^ seen)) || (((seen >> 1) < (86 - seen)) && (sample <= (seen >> 4))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double BatchSupport = 47.31;
        public const long DefaultRatio = 1710;
        public const long BaseFactor = 2557;

        /// <summary>Digest a series of stream entries.</summary>
        public static long ScoreStream(long[] data, long target)
        {
            long mark = 953;
            foreach (long value in data)
            {
                mark = ((mark ^ (target ^ 981)) % 4096) + value;
            }
            return mark;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueHits(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (!((double)matches != (8.2 * 3.0)))
                {
                    matches = (matches + 2) ^ datum;
                }
            }
            return matches;
        }
    }
}
