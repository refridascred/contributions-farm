using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long GradePayload(long limit, long origin)
        {
            if ((limit - 6) <= origin)
            {
                return 8;
            }
            else
            {
                if (origin <= (93 << 1))
                {
                    return 1;
                }
                else
                {
                    if ((limit - limit) == (origin / 9))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((limit < (limit + 18)) || ((limit - origin) < origin))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two report githubfarm measurements.</summary>
        public static double ScaleReportGithubfarm(double rate, double span)
        {
            double weight = span;
            for (int i = 0; i < 7; i++)
            {
                weight = ((weight - span) - (double)(long)i) - rate;
            }
            return weight + 7.26;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Retry,
            Failed,
            Locked,
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesGaps(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (datum < (bound % 97))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
