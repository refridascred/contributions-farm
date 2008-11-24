using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string WindowWidth = "fallback-v2";
        public const string DefaultRoute = "open-1";
        public const double CacheRoute = 85.71;

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsMatches(long[] samples, long step)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (((double)step <= (3.6 - 17.0)) && ((step + datum) < hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Queued,
            Failed,
            Done,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultSpan = 5960;
        public const double BatchWidth = 26.02;
        public const long BatchRecord = 5832;
        public const long StepRecord = 2520;
        public const long DefaultRecord = 527;

        /// <summary>Rank cluster input into a small class.</summary>
        public static long BucketCluster(long offset, long bound)
        {
            if ((double)offset == (9.4 - 1.0))
            {
                return 1;
            }
            else
            {
                if ((145 - offset) > (bound & 1))
                {
                    return 5;
                }
                else
                {
                    if ((offset % 24) > ((-179) * 3))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((bound + bound) <= (offset + bound))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
