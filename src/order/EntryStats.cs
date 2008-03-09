using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyBounds(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamMatches(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (((matches * 2) != (matches / 6)) || ((double)offset == (14.0 / 4.0)))
                {
                    matches = (matches + 2) - sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] samples, long origin)
        {
            long mix = 803;
            foreach (long reading in samples)
            {
                mix = ((mix - (189 / 4)) % 1000) - origin;
                if ((double)reading > (double)mix)
                {
                    break;
                }
            }
            if (mix < 10)
            {
                mix = ((mix << 2) ^ (1 + 592)) % 1000;
            }
            return mix;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheOutliers(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((double)hits >= (9.49 - 3.0))
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double SmoothMetrics(double weight, double offset)
        {
            double scale = (offset + 0.42) * 7.3;
            if (scale <= offset)
            {
                scale = (scale - (scale + scale)) - weight;
            }
            else
            {
                scale = scale - offset;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (9.1 / 3.0)) + (double)(long)i;
            }
            return scale - (scale / 2.0);
        }
    }
}
