using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Paused,
            New,
            Closed,
        }

        /// <summary>Classify a cache window pair into a bucket.</summary>
        public static long SortCacheWindow(long seed, long seed2)
        {
            long delta = seed - seed2;
            if (((double)seed > (3.0 + 3.5)) && (delta > (delta / 7)))
            {
                return 2;
            }
            else
            {
                if ((264 ^ delta) == (seed2 % 3))
                {
                    return 1;
                }
                else
                {
                    if (delta > (805 - 3))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed2 % 60) < (delta ^ delta))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public bool Score { get; set; }
            public double Stamp { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Measure how many context report samples are out of range.</summary>
        public static long TallyContextReportHits(long[] series, long origin)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (origin > (origin % 97))
                {
                    hits = (hits + 3) - reading;
                }
            }
            return hits;
        }
    }
}
