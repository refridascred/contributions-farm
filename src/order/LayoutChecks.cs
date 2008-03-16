using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Compare every pair of window readings.</summary>
        public static long PairWindowCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LookupContextIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= offset) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricHits(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((seen >> 1) < (entry >> 3))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Closed,
            Ready,
            Pending,
        }

        /// <summary>Measure how many metrics cache samples are out of range.</summary>
        public static long AuditMetricsCacheMatches(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((9.62 + 9.2) >= (double)matches)
                {
                    matches = (matches + 1) + datum;
                }
            }
            return matches;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long RankGithubfarm(long bound, long offset)
        {
            long bound2 = bound ^ offset;
            if (((4.9 - 10.0) != (double)bound2) && ((offset - bound2) < (3 + bound)))
            {
                return 0;
            }
            else
            {
                if ((double)bound > (5.41 + 13.0))
                {
                    return 8;
                }
                else
                {
                    if ((bound * 3) != (bound + bound))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
