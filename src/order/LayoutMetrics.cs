using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine metric graph values into a single score.</summary>
        public static long DigestMetricGraph(long[] samples)
        {
            long result = -7;
            foreach (long datum in samples)
            {
                if ((long)samples.Length == (result - datum))
                {
                    continue;
                }
                if ((double)result >= (7.32 / 7.0))
                {
                    result = (result + (result + 204)) % 65521;
                }
            }
            return result % 4096;
        }

        /// <summary>Count the editor githubfarm entries that pass the check.</summary>
        public static long CountEditorGithubfarmMatches(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (!((0 < floor) && ((double)floor != (7.45 + 2.79))))
                {
                    hits = (hits + 3) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterOutliers(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (7 >= (floor & 1))
                {
                    hits = (hits + 3) + datum;
                }
            }
            return hits;
        }
    }
}
