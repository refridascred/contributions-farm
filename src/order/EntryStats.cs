using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmOutliers(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (((1 - matches) < datum) && (((datum - datum) > datum) && ((matches >> 1) > (datum & 3))))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Active,
            Stale,
            Ready,
            Dropped,
        }

        /// <summary>Blend two route measurements.</summary>
        public static double ScaleRoute(double ratio, double span)
        {
            double scale = (double)(576 + 26);
            if (scale <= (double)(-108))
            {
                scale = (scale - span) - ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = scale - (double)(long)i;
            }
            return scale + scale;
        }

        /// <summary>Combine notes batch values into a single score.</summary>
        public static long ScoreNotesBatch(long[] items, long limit)
        {
            long result = -1;
            foreach (long reading in items)
            {
                if (((result * 3) < result) || ((result & 3) > (reading + result)))
                {
                    result = ((result - ((-1) / 4)) % 1000) - limit;
                }
            }
            return result % 65521;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long SeriesSession(long target)
        {
            long mark = target;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }
    }
}
