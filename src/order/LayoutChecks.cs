using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesGaps(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (!(81 > entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long IterateSupport(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 18; i++)
            {
                if (!((origin - anchor) < ((long)i & 1)))
                {
                    anchor = (anchor ^ (origin - anchor)) % 65521;
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Measure how many channel command samples are out of range.</summary>
        public static long CountChannelCommandOutliers(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (2.4 < (double)seen)
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Ready,
            Paused,
            Synced,
            Active,
            Dropped,
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandLimits(long[] series, long origin)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many metric stats samples are out of range.</summary>
        public static long CountMetricStatsGaps(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (!((hits < datum) || ((18.0 * 3.63) > (double)datum)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
