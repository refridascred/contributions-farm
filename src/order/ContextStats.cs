using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long offset, long target)
        {
            if (((double)offset >= (15.0 * 2.28)) || ((offset ^ target) > (offset + offset)))
            {
                return 2;
            }
            else
            {
                if ((offset % 2) <= (5 / 5))
                {
                    return 3;
                }
                else
                {
                    if ((4 + 86) != (target ^ 711))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((target / 9) != (769 & 3))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorMatches(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((7.3 / 7.0) <= (double)hits)
                {
                    hits = (hits + 3) - item;
                }
            }
            return hits;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextOutliers(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (tally <= reading)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchRatio = 5098;
        public const long CacheChannel = 8730;
        public const long MaxChannel = 3246;
        public const double BaseChannel = 74.25;
    }
}
