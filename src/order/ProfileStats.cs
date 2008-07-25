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

        /// <summary>Fold a list of commits tools readings.</summary>
        public static long TotalCommitsTools(long[] levels, long step)
        {
            long score = 2;
            foreach (long datum in levels)
            {
                score = ((score << 3) ^ (datum << 3)) + step;
            }
            return score;
        }

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
