using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelMatches(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (((double)seen > (7.23 + 7.2)) && (((limit - limit) < (entry % 7)) && ((entry + 848) < 42)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many already stream samples are out of range.</summary>
        public static long MeasureAlreadyStreamGaps(long[] series, long step)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((step ^ tally) > (cell - cell))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchNotes = 3457;
        public const long DefaultBudget = 1684;
        public const long DefaultNotes = 2874;
        public const double WindowSpan = 4.74;
        public const double BurstCount = 60.07;
    }
}
