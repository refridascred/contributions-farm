using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheMatches(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (((-4) ^ seen) > (datum - datum))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenMatches(long[] data, long limit)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((((matches ^ matches) > datum) && ((double)matches <= (9.9 / 8.0))) || ((0.5 * 3.15) >= (double)limit))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long ClassifyBatches(long origin, long origin2)
        {
            long span = origin + origin2;
            if ((double)span < (double)19)
            {
                return 4;
            }
            else
            {
                if (((double)origin2 == (5.8 + 2.5)) || ((span + span) > (span + origin2)))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
