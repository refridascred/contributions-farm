using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaRange(long[] data, long limit)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a stats session pair into a bucket.</summary>
        public static long RankStatsSession(long step, long seed)
        {
            if ((61 + step) >= (step >> 4))
            {
                return 5;
            }
            else
            {
                if ((15.0 / 7.0) <= 17.0)
                {
                    return 4;
                }
                else
                {
                    if (!(9.1 > (double)step))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((1.4 * 15.0) <= (double)seed)
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchHits(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((datum + hits) == (hits << 3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Closed,
            Synced,
            Queued,
            Stale,
            Paused,
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionGaps(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((96 - 909) > hits)
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }
    }
}
